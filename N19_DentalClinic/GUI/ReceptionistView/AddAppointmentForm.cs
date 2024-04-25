using Firebase.Auth;
using FirebaseAuthentication.AuthenticationTypes;
using N19_DentalClinic.GUI.ReceptionistView;
using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N19_DentalClinic.GUI.SupportView;

namespace N19_DentalClinic.controller.receptionist
{
    public partial class AddAppointmentForm : Form
    {
        Dictionary<int, string> stateApDic = new Dictionary<int, string>();
        List<string> FacultyListName = new List<string> { };
        private string ApID;
        private string interaction;
        DataInteraction data = new DataInteraction();
        private string facId = "";
        public AddAppointmentForm(string interaction, string apID)
        {
            InitializeComponent();
            this.interaction = interaction;
            ApID = apID;
            stateApDic.Add(0, "A");
            stateApDic.Add(1, "B");
            stateApDic.Add(2, "C");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            HMSPicker.Format = DateTimePickerFormat.Custom;
            HMSPicker.CustomFormat = "HH:mm:ss";
            switch (interaction)
            {
                case "create":
                    createEvent();
                    break;
                case "update":
                    updateEvent();
                    break;
                case "view":
                    viewEvent();
                    break;
                default:
                    MessageBox.Show("Tương tác lịch hẹn có lỗi:>>");
                    break;
            }
        }

        private void updateForm()
        {

        }

        private void createEvent()
        {
            btnAddAppointment.Text = "Tạo mới";
            tbSignal.ReadOnly = false;
            cbStatus.Enabled = true;
            btnChooseDay.Enabled = true;
            HMSPicker.Enabled = true;
            cbPatient.Enabled = true;
            cbFaculty.Enabled = true;
            btnDentistList.Enabled = true;
            btnAssisstantList.Enabled = true;
            btnPatientList.Enabled = true;
            btnSearchAssiID.Enabled = true;
            btnSearchDenId.Enabled = true;
            btnSearchPatId.Enabled = true;

            string sqlFacultyList = "select facid, name from faculty";
            DataTable tableFacList = data.readData(sqlFacultyList);
            if (tableFacList.Rows.Count > 0)
            {
                foreach (DataRow rowfac in tableFacList.Rows)
                {
                    cbFaculty.Items.Add(rowfac["name"].ToString());
                    FacultyListName.Add(rowfac["name"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Chưa có khoa trong dữ liệu" + "\r\n"
                             + " Vui lòng nhập thêm dữ liệu cho khoa");
            }
        }

        private void updateEvent()
        {
            //status dictionary
            Dictionary<string, string> cbstatuskeyvalue = new Dictionary<string, string>();
            cbstatuskeyvalue.Add("A", "Bệnh nhân chưa đến");
            cbstatuskeyvalue.Add("B", "Bệnh nhân đã đến");
            cbstatuskeyvalue.Add("C", "Cuộc hẹn kết thúc");
            //Them khoa vao combobox fac
            string sqlFacultyList = "select facid, name from faculty";
            DataTable tableFacList = data.readData(sqlFacultyList);
            if (tableFacList.Rows.Count > 0)
            {
                foreach (DataRow rowfac in tableFacList.Rows)
                {
                    cbFaculty.Items.Add(rowfac["name"].ToString());
                    FacultyListName.Add(rowfac["name"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Chưa có khoa trong dữ liệu" + "\r\n"
                             + " Vui lòng nhập thêm dữ liệu cho khoa");
            }

            //Chinh dinh dang cac o
            btnAddAppointment.Text = "Sửa";
            tbSignal.ReadOnly = false;
            cbStatus.Enabled = true;
            btnChooseDay.Enabled = true;
            HMSPicker.Enabled = true;
            cbPatient.Enabled = true;
            cbFaculty.Enabled = true;
            btnDentistList.Enabled = true;
            btnAssisstantList.Enabled = true;
            btnPatientList.Enabled = true;
            btnSearchAssiID.Enabled = true;
            btnSearchDenId.Enabled = true;
            btnSearchPatId.Enabled = true;

            string sqlAp = @$"select ap.apId, ap.ap_time, ap.patid, ap.denid, ap.symptom, ap.stateap,
                                d.name as denName, d.phone_number as denPhoneNum,
                                p.name as patName, p.gender as patGender, p.number as patPhoneNum,
                                p.address as patAddress, p.email as patEmail ,
                                f.name as facName,
                                ass.assiID as assiID, ass.name as asName, ass.phone_number as asPhoneNum
                                from Appointment ap 
                                join dentist d on d.denid = ap.denid
                                join patient p on p.patid = ap.patid
                                join faculty f on f.facid = d.facid
                                join assisstant ass on ass.assiID = ap.assiID
                                where ap.able = 1 and ap.apid = '{ApID}'";
            DataTable tableAp = data.readData(sqlAp);
            if (tableAp.Rows.Count > 0)
            {
                foreach (DataRow rowAp in tableAp.Rows)
                {
                    //Cuoc hen
                    tbSignal.Text = rowAp["symptom"].ToString();
                    cbStatus.Text = cbstatuskeyvalue[rowAp["stateap"].ToString()];
                    txtDay.Text = DateTimeConvert.convertDMY(rowAp["ap_time"].ToString());
                    HMSPicker.Text = DateTimeConvert.convertHMS(rowAp["ap_time"].ToString());

                    //Benh nhan
                    cbPatient.SelectedIndex = 0;
                    tbPatientId.Text = rowAp["patid"].ToString();
                    tbPatientAddress.Text = rowAp["patAddress"].ToString();
                    tbPatientName.Text = rowAp["patName"].ToString();
                    tbPatientPhoneNumber.Text = rowAp["patPhoneNum"].ToString();
                    if ((bool)rowAp["patGender"])
                    {
                        rbMale.Checked = true;
                        rbFemale.Checked = false;
                    }
                    else
                    {
                        rbMale.Checked = false;
                        rbFemale.Checked = true;
                    }
                    tbEmail.Text = rowAp["patEmail"].ToString();


                    //Nha si
                    cbFaculty.Text = rowAp["facName"].ToString();
                    tbDentistId.Text = rowAp["denid"].ToString();
                    tbDentistName.Text = rowAp["denName"].ToString();
                    tbDentistPhoneNumber.Text = rowAp["denPhoneNum"].ToString();

                    //Phu ta 
                    tbAssissId.Text = rowAp["assiID"].ToString();
                    tbAssissName.Text = rowAp["asName"].ToString();
                    tbAsissPhone.Text = rowAp["asPhoneNum"].ToString();
                }
            }

        }


        private void viewEvent()
        {
            updateEvent();
            btnAddAppointment.Text = "Tạo mới";
            tbSignal.ReadOnly = true;
            cbStatus.Enabled = false;
            btnChooseDay.Enabled = false;
            HMSPicker.Enabled = false;
            cbPatient.Enabled = false;
            cbFaculty.Enabled = false;
            tbDentistId.ReadOnly = true;
            btnAddAppointment.Enabled = true;
            btnDentistList.Enabled = false;
            btnAssisstantList.Enabled = false;
            btnPatientList.Enabled = false;
            btnSearchAssiID.Enabled = false;
            btnSearchDenId.Enabled = false;
            btnSearchPatId.Enabled = false;
        }

        private void btnSearchPatId_Click(object sender, EventArgs e)
        {
            //Kiem tra ma benh nhan
            string sqlPat = "select * from Patient where patId = '" + tbPatientId.Text + "'";
            DataTable tablePat = data.readData(sqlPat);
            if (tablePat.Rows.Count > 0)
            {
                foreach (DataRow rowPat in tablePat.Rows)
                {
                    //Hien thi thong tin benh nhan khi su kien tim kiem thanh cong
                    tbPatientName.Text = rowPat["name"].ToString();
                    tbPatientPhoneNumber.Text = rowPat["number"].ToString();
                    tbPatientAddress.Text = rowPat["address"].ToString();
                    tbEmail.Text = rowPat["email"].ToString();
                    if ((bool)rowPat["gender"])
                    {
                        rbMale.Checked = true;
                        rbFemale.Checked = false;
                    }
                    else
                    {
                        rbMale.Checked = false;
                        rbFemale.Checked = true;
                    }

                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã bệnh nhân này");
                //Xoa thong tin benh nhan cu
                tbPatientId.Text = "";
                tbPatientName.Text = "";
                tbPatientPhoneNumber.Text = "";
                tbPatientAddress.Text = "";
                tbEmail.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
            }
        }


        private void cbPatient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Phan theo loai benh nhan 
            if (cbPatient.SelectedIndex == 0)
            {
                //Tuong tac benh nhan cu
                btnPatientList.Enabled = true;
                tbPatientId.ReadOnly = false;
                btnSearchPatId.Enabled = true;
            }
            else
            {
                //Tuong tac benh nhan moi
                btnPatientList.Enabled = false;
                tbPatientId.ReadOnly = true;
                btnSearchPatId.Enabled = false;
                //1. Hien thi form dong y them benh nhan
                MessageBox.Show("Vui lòng thêm bệnh nhân mới ở hồ sơ bệnh nhân");
                //2. Xoa text combobox benh nhan
                tbPatientName.Text = "";
                tbPatientAddress.Text = "";
                tbPatientPhoneNumber.Text = "";
                tbPatientId.Text = "";
            }
        }

        private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sua lai noi dung khi thay doi khoa
            tbDentistName.Text = "";
            tbDentistPhoneNumber.Text = "";
            tbDentistId.Text = "";

            //Cap nhat facid
            string sqlFaculty = "select * from faculty";
            DataTable tableFac = data.readData(sqlFaculty);
            if (tableFac.Rows.Count > 0)
            {
                foreach (DataRow rowfac in tableFac.Rows)
                {
                    int rowIndex = tableFac.Rows.IndexOf(rowfac);
                    if (rowIndex == cbFaculty.SelectedIndex)
                    {
                        facId = rowfac["facid"].ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa có khoa nào trong phòng khám");
            }
            btnDentistList.Enabled = true;
            tbDentistId.ReadOnly = false;
            btnSearchDenId.Enabled = true;
        }

        private void btnSearchDenId_Click(object sender, EventArgs e)
        {
            if (facId == "")
            {
                MessageBox.Show("Vui lòng chọn khoa");
            }
            else
            {
                string sqlDen = "select * from dentist where facId = '" + facId + "'and denid = '" + tbDentistId.Text + "'";
                DataTable tableDen = data.readData(sqlDen);
                if (tableDen.Rows.Count > 0)
                {
                    foreach (DataRow rowden in tableDen.Rows)
                    {
                        if (rowden["denid"].ToString() == tbDentistId.Text)
                        {
                            tbDentistName.Text = rowden["name"].ToString();
                            tbDentistPhoneNumber.Text = rowden["phone_number"].ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã nha sĩ không có trong khoa này");
                    tbDentistId.Text = "";
                    tbDentistName.Text = "";
                    tbDentistPhoneNumber.Text = "";
                }
            }
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (tbSignal.Text == "")
            {
                MessageBox.Show("Vui lòng nhập triệu chứng");
            }
            else if (cbStatus.Text == "")
            {
                MessageBox.Show("Vui lòng chọn trạng thái cuộc hẹn");
            }
            else if (txtDay.Text == "")
            {
                MessageBox.Show("Vui lòng chọn ngày");
            }
            else if (DateTimeConvert.isPast(txtDay.Text))
            {
                MessageBox.Show("Ngày hẹn không thể ở quá khứ");
            }
            else if (tbPatientId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã bệnh nhân");
            }
            else if (tbDentistId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nha sĩ");
            }
            else if (tbAssissId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phụ tá");
            }
            else if (tbDentistName.Text == "" || tbPatientName.Text == "" || tbAssissName.Text == "")
            {
                MessageBox.Show("Vui lòng nhấn nút tìm kiếm (nha sĩ/bệnh nhân/phụ tá) để hoàn thiện thông tin");
            }
            else
            {
                string sqlApTimeDay = DateTimeConvert.convertSqlTimeDay(txtDay.Text);
                string sqlApTimeHour = DateTimeConvert.convertHMS(HMSPicker.Text);
                string sqlTime = sqlApTimeDay + " " + sqlApTimeHour;
                string sqlPatID = tbPatientId.Text;
                string sqlDenID = tbDentistId.Text;
                string sqlAssID = tbAssissId.Text;
                string sqlSymptom = tbSignal.Text;
                string sqlStateAp = stateApDic[cbStatus.SelectedIndex];
                string sqlNote = rtbNote.Text;

                //Kiem tra lich hen co trong gio lam viec cua nha si khong
                string sqlCheckTimeInCalendar = @$"select timeStart, timeEnd from calendar_dentist 
                        where denId = '{sqlDenID}'
                        and CONVERT(varchar(10), dayworks, 103)  = '{txtDay.Text}'";
                DataTable tableCheckTimeCalendar = data.readData(sqlCheckTimeInCalendar);
                if (tableCheckTimeCalendar.Rows.Count > 0)
                {
                    bool flagCheckTime = true;
                    foreach (DataRow row in tableCheckTimeCalendar.Rows)
                    {
                        string timeStartSql = row["timeStart"].ToString();
                        string timeEndSql = row["timeEnd"].ToString();

                        string timeStartHMS = DateTimeConvert.convertHMS(timeStartSql);
                        string timeEndHMS = DateTimeConvert.convertHMS(timeEndSql);

                        DateTime startSqlDT = Convert.ToDateTime(timeStartHMS);
                        DateTime endSqlDT = Convert.ToDateTime(timeEndHMS);
                        DateTime currTimeDt = Convert.ToDateTime(sqlApTimeHour);

                        if (currTimeDt >= startSqlDT && currTimeDt <= endSqlDT)
                        {
                            flagCheckTime = false;
                            break;
                        }
                    }

                    if (flagCheckTime)
                    {
                        MessageBox.Show("Bác sĩ không có giờ làm việc trong ngày này");
                        return;
                    }
                }else
                {
                    MessageBox.Show("Bác sĩ không có lịch làm việc trong ngày này");
                    return;
                }

                //Kiem tra lich hen co trong gio lam viec cua phu ta
                string sqlCheckTimeInCalendarAss = @$"select timeStart, timeEnd from calendar_assisstant
                        where assiID = '{sqlAssID}'
                        and CONVERT(varchar(10), dayworks, 103)  = '{txtDay.Text}'";
                DataTable tableCheckTimeCalendarAss = data.readData(sqlCheckTimeInCalendarAss);
                if (tableCheckTimeCalendarAss.Rows.Count > 0)
                {
                    bool flagCheckTime = true;
                    foreach (DataRow row in tableCheckTimeCalendarAss.Rows)
                    {
                        string timeStartSql = row["timeStart"].ToString();
                        string timeEndSql = row["timeEnd"].ToString();

                        string timeStartHMS = DateTimeConvert.convertHMS(timeStartSql);
                        string timeEndHMS = DateTimeConvert.convertHMS(timeEndSql);

                        DateTime startSqlDT = Convert.ToDateTime(timeStartHMS);
                        DateTime endSqlDT = Convert.ToDateTime(timeEndHMS);
                        DateTime currTimeDt = Convert.ToDateTime(sqlApTimeHour);

                        if (currTimeDt >= startSqlDT && currTimeDt <= endSqlDT)
                        {
                            flagCheckTime = false;
                            break;      
                        }
                    }

                    if (flagCheckTime)
                    {
                        MessageBox.Show("Phụ tá không có giờ làm việc trong ngày này");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Phụ tá không có lịch làm việc trong ngày này");
                    return;
                }

                if (interaction == "create")
                {
                    string sqlAddApp = $@"exec procAddAppointment
                            '{sqlTime}', 
                            '{sqlPatID}',
                            '{sqlDenID}',
                            '{sqlAssID}',
                            N'{sqlSymptom}',
                            '{sqlStateAp}',
                            '{sqlNote}'";
                    data.changeData(sqlAddApp);
                    MessageBox.Show("Thêm lịch thành công");
                    this.Close();
                }
                else if (interaction == "update")
                {
                    string sqlUpdateApp = @$"update appointment 
                        set ap_time = '{sqlTime}',
                            patid = '{sqlPatID}',
                            denid = '{sqlDenID}',
                            assiID = '{sqlAssID}',
                            symptom = N'{sqlSymptom}',
                            stateap = '{sqlStateAp}',
                            note = N'{sqlNote}'
                        where apid = '{ApID}' and able = 1";
                    data.changeData(sqlUpdateApp);
                    MessageBox.Show("Thay đổi lịch thành công");
                    this.Close();
                }
            }

        }

        private void btnChooseDay_Click(object sender, EventArgs e)
        {
            Calendar calendarF = new Calendar();
            calendarF.ShowDialog();
            DateTime currentDate = calendarF.GetDateSelector();
            string sqlTime = DateTimeConvert.convertSqlTime(currentDate.ToString());
            txtDay.Text = DateTimeConvert.convertDMY(currentDate.ToString());
        }

        private void tbPatientId_TextChanged(object sender, EventArgs e)
        {
            tbPatientName.Text = "";
            tbPatientPhoneNumber.Text = "";
            tbPatientAddress.Text = "";
            tbEmail.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private void tbDentistId_TextChanged(object sender, EventArgs e)
        {
            tbDentistName.Text = "";
            tbDentistPhoneNumber.Text = "";
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            PatientFileCopy fileCopy = new PatientFileCopy();
            fileCopy.ShowDialog();
        }

        //Tim phu ta
        private void btnSearchAssiID_Click(object sender, EventArgs e)
        {
            string sqlAss = "select * from assisstant where  assiID = '" + tbAssissId.Text + "'";
            DataTable tableAss = data.readData(sqlAss);
            if (tableAss.Rows.Count > 0)
            {
                foreach (DataRow rowAss in tableAss.Rows)
                {
                    if (rowAss["assiID"].ToString() == tbAssissId.Text)
                    {
                        tbAssissName.Text = rowAss["name"].ToString();
                        tbAsissPhone.Text = rowAss["phone_number"].ToString();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Mã phụ tá không tồn tại");
                tbAssissId.Text = "";
                tbAssissName.Text = "";
                tbAsissPhone.Text = "";
            }
        }

        private void tbAssissId_TextChanged(object sender, EventArgs e)
        {
            tbAssissName.Text = "";
            tbAsissPhone.Text = "";
        }

        private void btnDentistList_Click(object sender, EventArgs e)
        {
            DentistFileCopy fileCopy = new DentistFileCopy();
            fileCopy.ShowDialog();
        }
    }
}

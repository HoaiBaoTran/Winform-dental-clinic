CREATE FUNCTION CalculateDailyRevenue(@DateStart DATETIME, @DateEnd DATETIME)
RETURNS TABLE
AS
RETURN
(
    SELECT CONVERT(date, payment_time) AS payment_date, SUM(total_price) AS daily_revenue
    FROM bill
    WHERE payment_time BETWEEN @DateStart AND @DateEnd
    GROUP BY CONVERT(date, payment_time)
)
GO


CREATE FUNCTION CalculateMonthlyRevenue(@DateStart DATETIME, @DateEnd DATETIME)
RETURNS TABLE
AS
RETURN
(
    SELECT DATEFROMPARTS(YEAR(payment_time), MONTH(payment_time), 1) AS payment_month, SUM(total_price) AS monthly_revenue
    FROM bill
    WHERE payment_time BETWEEN @DateStart AND @DateEnd
    GROUP BY YEAR(payment_time), MONTH(payment_time)
)
GO

CREATE FUNCTION CalculateYearlyRevenue(@DateStart DATETIME, @DateEnd DATETIME)
RETURNS TABLE
AS
RETURN
(
    SELECT YEAR(payment_time) AS payment_year, SUM(total_price) AS yearly_revenue
    FROM bill
    WHERE payment_time BETWEEN @DateStart AND @DateEnd
    GROUP BY YEAR(payment_time)
)
GO

CREATE FUNCTION CalculateQuarterlyRevenue (@dateFrom DATETIME, @dateTo DATETIME)
RETURNS @QuarterlyRevenue TABLE (
    payment_year INT,
    payment_quarter INT,
    quarterly_revenue DECIMAL(18, 2)
)
AS
BEGIN
    INSERT INTO @QuarterlyRevenue (payment_year, payment_quarter, quarterly_revenue)
    SELECT
        DATEPART(year, payment_time) AS payment_year,
        DATEPART(quarter, payment_time) AS payment_quarter,
        SUM(total_price) AS quarterly_revenue
    FROM
        Bill
    WHERE
        payment_time BETWEEN @dateFrom AND @dateTo
    GROUP BY
        DATEPART(year, payment_time),
        DATEPART(quarter, payment_time)
    ORDER BY
        payment_year, payment_quarter;

    RETURN;
END;
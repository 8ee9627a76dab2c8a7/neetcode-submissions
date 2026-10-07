-- Write your query below
select date_id, make_name, COUNT(DISTINCT(lead_id)) as unique_leads, COUNT(DISTINCT(partner_id)) as unique_partners
from daily_sales
group by make_name, date_id
order by date_id DESC

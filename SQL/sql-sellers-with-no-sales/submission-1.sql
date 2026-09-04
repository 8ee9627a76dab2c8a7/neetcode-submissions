-- Write your query below
select seller_name
from seller as s
left join orders as o on s.seller_id = o.seller_id and o.sale_date between '2020-01-01' AND '2020-12-31'
where o.seller_id is null
order by seller_name asc
-- Write your query below
select name 
from customers as c
LEFT JOIN orders as o on o.customer_id = c.id
where o.customer_id IS NULL
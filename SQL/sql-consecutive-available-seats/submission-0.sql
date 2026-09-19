-- Write your query below
WITH cte AS (SELECT seat_id, free, LAG(free) OVER (ORDER BY seat_id) AS prev_free, LEAD(free) OVER (ORDER BY seat_id) AS next_free FROM cinema)

select seat_id
from cte
where free = 1 AND (prev_free = 1 or next_free = 1)
order by seat_id
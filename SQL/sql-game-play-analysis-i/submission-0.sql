-- Write your query below
select player_id, MIN(event_date) as first_login
from activity as a 
group by a.player_id
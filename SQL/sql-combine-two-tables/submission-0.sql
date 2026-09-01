-- Write your query belows
select first_name, last_name, city, state
from person as p 
left join address as a on a.person_id = p.person_id

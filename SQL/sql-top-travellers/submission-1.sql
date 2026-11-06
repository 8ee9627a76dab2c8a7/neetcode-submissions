-- Write your query below
select name, COALESCE(SUM(r.distance), 0) as travelled_distance
from users as u
left join rides as r on u.id = r.user_id
group by u.id, u.name
order by travelled_distance DESC, u.name ASC

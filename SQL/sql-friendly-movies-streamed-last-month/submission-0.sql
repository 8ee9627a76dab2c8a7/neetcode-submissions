-- Write your query below
SELECT DISTINCT c.title
FROM tv_program tp
JOIN content c ON tp.content_id = c.content_id
WHERE c.kids_content = 'Y'
  AND c.content_type = 'Movies'
  AND tp.program_date LIKE '2020-06%';

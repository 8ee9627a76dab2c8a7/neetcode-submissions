SELECT d.name AS department, e.name AS employee, e.salary
FROM employee e
INNER JOIN department d ON e.department_id = d.id
WHERE e.salary = (
    SELECT MAX(e2.salary)
    FROM employee e2
    WHERE e2.department_id = e.department_id
);

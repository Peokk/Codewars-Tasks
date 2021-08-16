SELECT * FROM departments d WHERE EXISTS (SELECT * FROM sales s WHERE s.price > 98.00 AND s.department_id = d.id);

SELECT p.id, p.name, COUNT(*) AS sale_count, RANK() OVER (PARTITION BY p.id ORDER BY count(*) DESC) AS sale_rank 
FROM people p 
JOIN sales ON sales.people_id = p.id 
GROUP BY p.id, p.name;
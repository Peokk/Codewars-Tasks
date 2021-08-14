SELECT p.name, 
count(CASE WHEN d.detail = 'good' THEN 1 END) as good, 
count(CASE WHEN d.detail = 'ok' THEN 1 END) as ok, 
count(CASE WHEN d.detail = 'bad' THEN 1 END) as bad 
FROM products p 
JOIN details d ON p.id = d.product_id 
GROUP BY p.name 
ORDER BY p.name;
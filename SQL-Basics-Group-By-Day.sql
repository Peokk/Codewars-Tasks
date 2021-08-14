SELECT created_at::date AS day, description, count(*)
FROM events
WHERE name = 'trained'
GROUP BY created_at::date, description;
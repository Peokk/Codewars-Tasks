SELECT p.id, p.name, count(*) as toy_count FROM people p JOIN toys t ON t.people_id = p.id GROUP BY p.id, p.name
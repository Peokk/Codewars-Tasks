SELECT age, count(*) as total_people FROM people GROUP BY age HAVING count(*) >= 10;

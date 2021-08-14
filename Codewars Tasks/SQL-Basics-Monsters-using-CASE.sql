SELECT t.id, t.heads, t.arms, b.legs, b.tails, 
CASE WHEN t.heads > t.arms OR b.tails > b.legs 
THEN 'BEAST' ELSE 'WEIRDO' 
END as species FROM top_half t 
JOIN bottom_half b ON b.id = t.id 
ORDER BY species 
LIMIT 10;

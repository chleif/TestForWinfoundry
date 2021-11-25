SELECT
p.firstName , p.lastName , a.city , a.state
FROM Person p
LEFT OUTER JOIN  Address a ON a.personID = p.personId
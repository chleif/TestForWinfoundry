SELECT
c.name
FROM Customers c
LEFT OUTER JOIN Orders o ON c.id =o.customerId
WHERE o.customerId IS NULL
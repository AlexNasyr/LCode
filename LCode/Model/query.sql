use relationsdb
select 
	Tickets.ClientId
	, Count(*) as QueryQuontity
	, Clients.Name
from Tickets, Clients
where Tickets.ClientId = Clients.Id
group by Tickets.ClientId, Clients.Name
having Count(*) < 3
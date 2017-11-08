SELECT COUNT(*) AS 'countEvents'
FROM tb_EventInfo EI 
JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
JOIN tb_Capacity C ON S.scheduleID = C.scheduleID 
JOIN tb_TicketAmount TA ON S.scheduleID = TA.scheduleID 
JOIN tb_FBGroupID FBGI ON S.scheduleID = FBGI.scheduleID
WHERE eventName = 'Seminar' and ((@dateStart between dateStart 
and dateEnd or @dateEnd between dateStart and dateEnd)  
and CAST(@timeStart AS time) BETWEEN timeStart and timeEnd or CAST(@timeEnd AS time) 
BETWEEN timeStart and timeEnd) and (locationAdd = @locationAdd and venueName = @venueName)

SELECT COUNT(*) AS 'countEvents'
FROM tb_EventInfo EI 
JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
JOIN tb_Capacity C ON S.scheduleID = C.scheduleID 
JOIN tb_TicketAmount TA ON S.scheduleID = TA.scheduleID 
JOIN tb_FBGroupID FBGI ON S.scheduleID = FBGI.scheduleID
WHERE ((eventName = @eventName and locationAdd = @locationAdd) and (venueName = @venueName))
and (((@dateStart between dateStart and dateEnd) and (CAST(@timeStart AS time) BETWEEN timeStart 
and timeEnd or CAST(@timeEnd AS time) BETWEEN timeStart and timeEnd)) 
or
(timeStart BETWEEN CAST(@timeStart AS time) and 
CAST(@timeEnd AS time) or timeEnd  BETWEEN CAST(@timeStart AS time) and CAST(@timeEnd AS time)))


SELECT COUNT(*) AS 'countEvents'
FROM tb_EventInfo EI 
JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
JOIN tb_Capacity C ON S.scheduleID = C.scheduleID 
JOIN tb_TicketAmount TA ON S.scheduleID = TA.scheduleID 
JOIN tb_FBGroupID FBGI ON S.scheduleID = FBGI.scheduleID
WHERE (locationAdd = @locationAdd and venueName = @venueName)
and ((((@dateStart between dateStart and dateEnd) or (@dateEnd between dateStart and dateEnd)) and (CAST(@timeStart AS time) BETWEEN timeStart 
and timeEnd or CAST(@timeEnd AS time) BETWEEN timeStart and timeEnd)) 
or
(((dateStart between @dateStart and @dateEnd) or (dateStart between @dateStart and @dateEnd)) or (timeStart BETWEEN CAST(@timeStart AS time) and 
CAST(@timeEnd AS time) or timeEnd  BETWEEN CAST(@timeStart AS time) and CAST(@timeEnd AS time))))






SELECT EI.scheduleID, eventName, [description], isPastEvent, dateStart, dateEnd, timeStart, 
timeEnd, locationAdd, venueName, ticketCapacity, ticketAmount, fbGroupCode
FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
JOIN tb_Capacity C ON S.scheduleID = C.scheduleID JOIN tb_TicketAmount TA ON
S.scheduleID = TA.scheduleID JOIN tb_FBGroupID FBGI ON S.scheduleID = FBGI.scheduleID
where isPastEvent != 1


DELETE tb_EventInfo 
FROM  tb_EventInfo JOIN tb_Schedule 
ON tb_EventInfo.scheduleID = tb_Schedule.scheduleID
JOIN tb_Capacity 
ON tb_Capacity.scheduleID = tb_Schedule.scheduleID 
JOIN tb_TicketAmount 
ON tb_TicketAmount.scheduleID = tb_Schedule.scheduleID 
JOIN tb_FBGroupID 
ON tb_FBGroupID.scheduleID = tb_Schedule.scheduleID
WHERE scheduleID is not equal '16'

select * from tb_EventInfo

delete from tb_FBGroupID f join tb_schedule s f on  where scheduleID = '0' or scheduleID = '1234567890'

select * from tb_FBGroupID

alter table tb_FBGroupID
add constraint fk_FBGroupID Foreign key(scheduleID)
references tb_Schedule(scheduleID) on delete cascade on update cascade

alter table tb_eventinfo
drop constraint fk_eventinfo 


select * FROM tb_Schedule

select * from tb_Capacity

alter table tb_loggedAdmin
alter column adminID int not null

select * from tb_systemLogs


SELECT eventName, [description], dateStart, dateEnd, 
LEFT(timeStart, 2) AS 'hrTimestart', SUBSTRING(CAST(timeStart AS varchar(15)), 4,2) AS 'minTimestart',
LEFT(timeEnd, 2) AS 'hrTimeend', SUBSTRING(CAST(timeEnd AS varchar(15)), 4,2) AS 'minTimeend', 
venueName, locationAdd, ticketCapacity, ticketAmount, fbGroupCode
FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
where EI.scheduleID != '19'


SELECT eventName, [description], dateStart, dateEnd, 
LEFT(timeStart, 2) AS 'hrTimestart', timeStart
FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
JOIN tb_Capacity C ON S.scheduleID = C.scheduleID JOIN tb_TicketAmount TA ON
S.scheduleID = TA.scheduleID JOIN tb_FBGroupID FBGI ON S.scheduleID = FBGI.scheduleID
where EI.scheduleID = '6'



delete  from tb_EventInfo where scheduleid = '10'

delete  from tb_Schedule where scheduleid = '10'



delete from tb_Capacity where capacityID = '10'

delete from tb_TicketAmount where scheduleid = '10'

delete from tb_FBGroupID where scheduleID = '10'

SELECT COUNT(*) AS 'countEvents'
FROM tb_EventInfo EI 
JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
JOIN tb_Capacity C ON S.scheduleID = C.scheduleID 
JOIN tb_TicketAmount TA ON S.scheduleID = TA.scheduleID 
JOIN tb_FBGroupID FBGI ON S.scheduleID = FBGI.scheduleID
WHERE ((locationAdd = @locationAdd and venueName = @venueName) and (EI.scheduleID != @scheduleID))
and ((((@dateStart between dateStart and dateEnd) or (@dateEnd between dateStart and dateEnd)) 
and (CAST(@timeStart AS time) BETWEEN timeStart and timeEnd or CAST(@timeEnd AS time) BETWEEN 
timeStart and timeEnd)) or (((dateStart between @dateStart and @dateEnd) or (dateStart between 
@dateStart and @dateEnd)) or (timeStart BETWEEN CAST(@timeStart AS time) and CAST(@timeEnd AS 
time) or timeEnd  BETWEEN CAST(@timeStart AS time) and CAST(@timeEnd AS time))))

UPDATE tb_EventInfo  
SET isPastEvent = '1'
WHERE scheduleID IN (SELECT scheduleID
					 FROM tb_Schedule
				     WHERE dateStart < GETDATE())

SELECT scheduleID
FROM tb_Schedule
WHERE dateStart < GETDATE()
AND timeStart < '11:00'; 

select * 
from tb_Schedule

print getdate()

select * 
from tb_EventInfo
where eventName = 'seminar'
and isPastEvent != 1

SELECT COUNT(*)
FROM tb_EventInfo
WHERE isPastEvent != 1

select *
from tb_adminInformations

select top 1 datediff(DAY, dateStart, getdate()) 
from tb_schedule
order by 1 asc

SELECT TOP 1 eventName, dateStart, dateEnd, LEFT(CAST(timeStart AS varchar (10)),5) AS 'tStart', LEFT(CAST(timeEnd AS varchar (10)),5) AS 'tEnd', locationAdd, venueName
FROM tb_schedule S JOIN tb_EventInfo E
ON S.scheduleID = E.scheduleID
where DATEDIFF(DAY, GETDATE(), dateStart) = (SELECT TOP 1 datediff(DAY, getdate(), dateStart) 
											 FROM tb_schedule S JOIN tb_EventInfo E
											 ON S.scheduleID = E.scheduleID
											 WHERE isPastEvent != 1
										     ORDER BY 1 ASC)
ORDER BY timeStart ASC


SELECT S.scheduleID,datediff(DAY, getdate(), dateStart), timeStart 
FROM tb_schedule S JOIN tb_EventInfo E
ON S.scheduleID = E.scheduleID
WHERE isPastEvent != 1
ORDER BY 2 ASC

select * from tb_Schedule

update tb_EventInfo
set isPastEvent = 0

select * from tb_EventInfo

alter table tb_adminInformations
add fbPassWord varchar(30) 

select * from
tb_adminInformations

SELECT fbUname, fbPassWord
FROM tb_adminInformations
WHERE adminID =

Update tb_adminInformations
SET fbUname = 'hello', fbPassWord = 'test'
where adminID = 2

SELECT eventName AS 'EVENT NAME', [description] AS 'DESCRIPTION',
FORMAT(dateStart, 'MMMM dd, yyyy') AS 'START DATE', 
FORMAT(dateEnd, 'MMMM dd, yyyy') AS 'END DATE', 
timeStart AS 'START TIME', timeEnd AS 'END TIME', 
venueName AS 'VENUE', locationAdd AS 'VENUE ADDRESS', ticketAmount AS 'TICKET AMOUNT'
FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
JOIN tb_Capacity C ON S.scheduleID = C.scheduleID JOIN tb_TicketAmount TA ON
S.scheduleID = TA.scheduleID JOIN tb_FBGroupID FBGI ON S.scheduleID = FBGI.scheduleID


SELECT DISTINCT eventName
FROM tb_eventInfo
WHERE isPastEvent != 1

SELECT COUNT(*) FROM tb_participantInformations

SELECT * FROM tb_participantInformations

insert into tb_participantInformations
values('1', 'Samonte', 'Ryan', '18', 'samonte@gmail.com', '100')

SELECT S.scheduleID, ticketAmount
FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
JOIN tb_TicketAmount TA ON TA.scheduleID = S.scheduleID 
WHERE ((eventName = 'Meps and Friends' AND dateStart = '2017-10-19') 
AND (dateEnd = '2017-10-20' AND timeStart = '01:00'))
AND ((timeEnd = '03:00' AND venueName = 'PUP') AND (locationAdd = 'Manila')) 

	Hello	October 19, 2017	October 20, 2017	01:00:00	03:00:00	PUP	Manila	0.00

	select * from tb_Ticket

select * from tb_participantInformations

select * from tb_schedule

select * from tb_eventinfo

dateEnd <= datetime.now
AND
timeEnd < time.now

update tb_EventInfo
set isPastEvent = '0'

delete from tb_schedule
where scheduleID in('14', '1', '3')

delete from tb_ticket
where qrCode = '1226'

select * from tb_ticket

select * from tb_participantInformations

select * from tb_EventInfo
select * from tb_schedule

select * from tb_TicketAmount

SELECT TOP 1 eventName, dateStart, dateEnd, 
                                                                  LEFT(CAST(timeStart AS varchar (10)),5) AS 'tStart', 
                                                                  LEFT(CAST(timeEnd AS varchar (10)),5) AS 'tEnd', locationAdd, venueName
                                                                  FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
                                                                  where DATEDIFF(DAY, GETDATE(), dateStart) = (SELECT TOP 1 datediff(DAY, getdate(), dateStart) 
											                                                                   FROM tb_schedule S JOIN tb_EventInfo E
											                                                                   ON S.scheduleID = E.scheduleID
											                                                                   WHERE isPastEvent != 1
										                                                                       ORDER BY 1 ASC) AND isPastEvent != 1
                                                                  ORDER BY timeStart ASC

select * from tb_capacity

alter table tb_capacity
add ticketBought int

update tb_capacity
set ticketBought = 0

SELECT EI.scheduleID, eventName, [description], 
                                                                        dateStart, dateEnd, timeStart, timeEnd, locationAdd, 
                                                                        venueName, ticketCapacity, ticketAmount, fbGroupCode 
                                                                        FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
                                                                        JOIN tb_Capacity C ON S.scheduleID = C.scheduleID 
                                                                        JOIN tb_TicketAmount TA ON S.scheduleID = TA.scheduleID 
                                                                        JOIN tb_FBGroupID FBGI ON S.scheduleID = FBGI.scheduleID
                                                                        WHERE isPastEvent != 1 AND ticketCapacity != ticketBought
                                                                        ORDER BY 4 ASC

update tb_Capacity
set ticketBought = 20
where scheduleID = 26

select * from tb_participantInformations

delete from tb_participantInformations where participantID = 30

select * from tb_Ticket
select * from tb_TicketAmount
select * from tb_Capacity

select * from tb_EventInfo

update tb_Ticket
set qrCode = '276', paymentStatus = 'UNPAID' 
where participantID = 27

select * from tb_Schedule

select * from tb_EventInfo

update tb_Schedule
set dateStart = '2018-10-04', dateEnd = '2018-10-04'
where scheduleID = 6

update tb_EventInfo
set isPastEvent = 0
where scheduleID = 6

UPDATE tb_Capacity
SET ticketBought = 0
WHERE scheduleID = 27

SELECT firstName, lastName, age, contactNum
FROM tb_participantInformations P JOIN tb_Ticket T
ON P.participantID = T.participantID
WHERE P.scheduleID = '26' AND T.paymentStatus = 'UNPAID'

ALTER Table tb_Schedule
add ticketBought int

select * from tb_Schedule

drop table tb_Capacity
drop table tb_FBGroupID
drop table tb_TicketAmount

UPDATE tb_Schedule
SET ticketCapacity = 20, FbGroupCode = '34567654546', ticketAmount = 20
WHERE scheduleID = 26


SELECT EI.scheduleID, eventName, [description], isPastEvent, dateStart, dateEnd, timeStart, 
timeEnd, locationAdd, venueName, ticketCapacity, ticketAmount, fbGroupCode
FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
where isPastEvent != 1
select * from tb_EventInfo

select * from tb_Schedule

update tb_Schedule
set ticketCapacity = 500, fbGroupCode = '9888888576890', ticketAmount = 700, ticketBought = 10
where scheduleID = 26

select * from tb_Ticket

SELECT COUNT(participantID) AS 'UNPAID'
FROM tb_Ticket
WHERE schedID = '6'
AND paymentStatus = 'UNPAID'

SELECT * FROM tb_systemLogs
WHERE timestamp BETWEEN '2017/09/20' AND '2017/10/08'

alter table tb_adminInformations
alter column passWord varchar(50) collate Latin1_General_CS_AS not null

alter table tb_Ticket
add isScanned bit

update tb_Ticket
set isScanned = 0

select * from tb_Ticket 

SELECT EI.scheduleID, eventName, [description], dateStart, timeStart, 
timeEnd
FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
where isPastEvent != 1 AND dateStart = 

select * from tb_Ticket

select * from tb_participantInformations

select * from tb_Schedule
SELECT COUNT(*) FROM tb_Ticket
WHERE (qrCode = '276PAID' AND paymentStatus = 'PAID') AND isScanned = 1

select * from tb_Ticket

select * from tb_participantInformations

SELECT COUNT(*) AS 'partTcount' FROM tb_participantInformations

SELECT TOP 1 participantID FROM tb_participantInformations ORDER BY participantID DESC

INSERT INTO tb_participantInformations
VALUES('33', 'yeye','yoyo', '14', '32', '9087687')

Select * from tb_Schedule
delete from tb_Ticket
where participantID = 32

select * from tb_Ticket

SELECT TOP 1 eventName, dateStart, dateEnd, 
LEFT(CAST(timeStart AS varchar (10)),5) AS 'tStart', 
LEFT(CAST(timeEnd AS varchar (10)),5) AS 'tEnd', locationAdd, venueName
FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
where (DATEDIFF(DAY, GETDATE(), dateStart) = (SELECT TOP 1 datediff(DAY, getdate(), dateStart) 
											 FROM tb_schedule S JOIN tb_EventInfo E
											 ON S.scheduleID = E.scheduleID
											 WHERE isPastEvent != 1 AND datediff(DAY, getdate(), dateStart) >= 0
										     ORDER BY 1 ASC) AND isPastEvent != 1)
ORDER BY timeStart ASC

SELECT eventName, datediff(DAY, getdate(), dateStart) 
											 FROM tb_schedule S JOIN tb_EventInfo E
											 ON S.scheduleID = E.scheduleID
											 WHERE isPastEvent != 1
										     ORDER BY 2 ASC

select * from tb_EventInfo

SELECT scheduleID
FROM tb_Schedule
WHERE dateEnd <= GETDATE()
OR timeEnd < '16:17'

update tb_EventInfo
set isPastEvent = 1
where scheduleID = 32

select * from tb_Schedule

select GETDATE()

select S.scheduleID
FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
WHERE CONVERT(DATETIME, CONVERT(CHAR(8), dateEnd, 112)+ ' ' +CONVERT(CHAR(8), timeEnd, 108)) <= GETDATE() 
AND CONVERT(DATETIME, CONVERT(CHAR(8), dateEnd, 112)+ ' ' +CONVERT(CHAR(8), timeEnd, 108)) < GETDATE()


                                                                        

SELECT EI.scheduleID, eventName, [description],
FORMAT(dateStart, 'yyyy-MM-dd'), dateEnd, timeStart, timeEnd, locationAdd, isPastEvent,
venueName, ticketCapacity, ticketAmount, fbGroupCode                                                                   
FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
WHERE (isPastEvent != 1 AND ticketCapacity != ticketBought)                                                                                                                                               
AND ((DATEADD(HOUR,-2,(CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112) 
  + ' ' + CONVERT(CHAR(8), timeStart, 108)))) !< GETDATE()))
ORDER BY 4 ASC      

SELECT EI.scheduleID, eventName, [description],
dateStart, dateEnd, timeStart, timeEnd, locationAdd, isPastEvent
FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
WHERE ((DATEADD(HOUR,-2,(CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112) 
  + ' ' + CONVERT(CHAR(8), timeStart, 108)))) !< GETDATE()) OR (DATEADD(HOUR,-2,(CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112) 
  + ' ' + CONVERT(CHAR(8), timeStart, 108)))) != GETDATE()))

SELECT EI.scheduleID, eventName, [description],
dateStart, dateEnd, timeStart, timeEnd, locationAdd, isPastEvent,
venueName, ticketCapacity, ticketAmount, fbGroupCode, ticketBought, DATEADD(HOUR,-2,(CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112) 
  + ' ' + CONVERT(CHAR(8), timeStart, 108))))
FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID     

SELECT LEFT(timeStart, 2) AS 'hrTimestart', SUBSTRING(CAST(timeStart 
                                                               AS varchar(15)), 4,2) AS 'minTimestart'
                                                               FROM tb_Schedule         
															   
select * from tb_Ticket  

SELECT isPastEvent
FROM tb_EventInfo
WHERE scheduleID = 26

select * from tb_EventInfo 

update tb_EventInfo
set isPastEvent = '1'
where scheduleID = 22 

select * from tb_Schedule

alter table tb_schedule
drop column locationAdd

select * from tb_adminInformations             


SELECT COUNT(*) AS 'countEvents'
FROM tb_EventInfo EI JOIN tb_Schedule S 
ON EI.scheduleID = s.scheduleID
WHERE (venueName = 'PUP' and isPastEvent != 1)
and ((('2017-10-19' between dateStart 
and dateEnd) and (CAST('12:01' AS time) BETWEEN timeStart 
and timeEnd or CAST('14:00' AS time) BETWEEN timeStart and timeEnd)) 
or (timeStart BETWEEN CAST('12:01' AS time) and CAST('14:00' AS time) 
or timeEnd  BETWEEN CAST('12:01' AS time) and CAST('14:00' AS time)))



SELECT COUNT(*) AS 'countEvents'
FROM tb_EventInfo EI JOIN tb_Schedule S 
ON EI.scheduleID = s.scheduleID
WHERE (venueName = 'PUP' and isPastEvent != 1)
and ((('2017-10-19' between dateStart 
and dateEnd) and (CAST('03:01' AS time) BETWEEN timeStart 
and timeEnd or CAST('05:00' AS time) BETWEEN timeStart and timeEnd)) 
or (timeStart BETWEEN CAST('03:01' AS time) and CAST('05:00' AS time) 
or timeEnd  BETWEEN CAST('03:01' AS time) and CAST('05:00' AS time))) 

SELECT *
FROM tb_EventInfo EI JOIN tb_Schedule S 
ON EI.scheduleID = s.scheduleID 
WHERE s.scheduleID IN (16,19,24,26,27,31,32,1030,1031,2030,2031)        

SELECT S.scheduleID
FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
WHERE CONVERT(DATETIME, CONVERT(CHAR(8), dateEnd, 112)+ ' ' +CONVERT(CHAR(8), timeEnd, 108)) <= GETDATE() 
AND CONVERT(DATETIME, CONVERT(CHAR(8), dateEnd, 112)+ ' ' +CONVERT(CHAR(8), timeEnd, 108)) < GETDATE()                 	

SELECT EI.scheduleID, eventName, [description],
                                                                        FORMAT(dateStart, 'MMMM dd, yyyy') AS 'dateStart', FORMAT(dateEnd, 'MMMM dd, yyyy') AS 'dateEnd', 
                                                                        timeStart, timeEnd,
                                                                        venueName, ticketCapacity, ticketAmount, fbGroupCode                                                                    
                                                                        FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
                                                                        WHERE (isPastEvent != 1 AND ticketCapacity != ticketBought)                                                                                                                                               
                                                                        AND ((DATEADD(HOUR,-2,(CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112) 
                                                                        + ' ' + CONVERT(CHAR(8), timeStart, 108)))) !< GETDATE()))
                                                                        ORDER BY FORMAT(dateStart, 'yyyy-MM-dd') ASC		
																		
update tb_EventInfo
set isPastEvent = 0
where scheduleID IN(2030, 2031)		


SELECT TOP 1 eventName, dateStart, dateEnd, 
LEFT(CAST(timeStart AS varchar (10)),5) AS 'tStart', 
LEFT(CAST(timeEnd AS varchar (10)),5) AS 'tEnd', venueName
FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
where DATEDIFF(DAY, GETDATE(), dateStart) = (SELECT TOP 1 datediff(DAY, getdate(), dateStart) 
											 FROM tb_schedule S JOIN tb_EventInfo E
											 ON S.scheduleID = E.scheduleID
											 WHERE isPastEvent != 1 AND datediff(DAY, getdate(), dateStart) >= 0
										     ORDER BY 1 ASC) AND isPastEvent != 1
ORDER BY timeStart ASC





SELECT TOP 1 S.scheduleID
FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
where (DATEDIFF(DAY, GETDATE(), dateStart) IN (SELECT TOP 1 datediff(DAY, getdate(), dateStart) 
											 FROM tb_schedule S JOIN tb_EventInfo E
											 ON S.scheduleID = E.scheduleID
											 WHERE (isPastEvent != 1 AND datediff(DAY, getdate(), dateStart) >= 0) AND (CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108)) !< GETDATE())
										     ORDER BY 1 ASC)) AND (isPastEvent != 1 AND CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108)) !< GETDATE())
ORDER BY timeStart ASC

						
SELECT COUNT(*)
FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
WHERE S.scheduleID = '26' AND (SELECT CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108))
							   FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
							   WHERE S.scheduleID = '26') < GETDATE();

Select * from tb_participantInformations

select * from tb_ticket
							   
SELECT COUNT(*) AS 'partCount'
FROM tb_participantInformations P JOIN tb_Ticket T
ON P.participantID = T.participantID
WHERE scheduleID = (SELECT TOP 1 S.scheduleID
					FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
					where (DATEDIFF(DAY, GETDATE(), dateStart) IN (SELECT TOP 1 datediff(DAY, getdate(), dateStart) 
																   FROM tb_schedule S JOIN tb_EventInfo E
																   ON S.scheduleID = E.scheduleID
																   WHERE (isPastEvent != 1 AND datediff(DAY, getdate(), dateStart) >= 0) AND (CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108)) !< GETDATE())
																   ORDER BY 1 ASC)) AND (isPastEvent != 1 AND CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108)) !< GETDATE())
					ORDER BY timeStart ASC)
AND paymentStatus = 'PAID'

select * from tb_Schedule
						
SELECT CONVERT(varchar(15),timeStart,100) AS 'timeStart', timeStart
FROM tb_Schedule

select * from tb_participantInformations

select * from tb_Ticket

select * from tb_EventInfo

select * from tb_Schedule

SELECT eventName AS 'EVENT NAME', [description] AS 'DESCRIPTION',
                                                  FORMAT(dateStart, 'MMMM dd, yyyy') AS 'START DATE', 
                                                  FORMAT(dateEnd, 'MMMM dd, yyyy') AS 'END DATE', 
                                                  timeStart AS 'START TIME', timeEnd AS 'END TIME', 
                                                  venueName AS 'VENUE', 
                                                  ticketAmount AS 'TICKET AMOUNT'
                                                  FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
                                                  WHERE (isPastEvent != 1 AND ticketCapacity != ticketBought)                                                                                                                                               
                                                  AND ((DATEADD(HOUR,-2,(CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112) 
                                                  + ' ' + CONVERT(CHAR(8), timeStart, 108)))) !< GETDATE()))
                                                  ORDER BY FORMAT(dateStart, 'yyyy-MM-dd') ASC

update tb_Schedule
set timeStart = '01:40'
where scheduleID = '26'


DELETE FROM tb_adminInformations
DELETE FROM tb_EventInfo
DELETE FROM tb_loggedAdmin
DELETE FROM tb_participantInformations
DELETE FROM tb_Schedule
DELETE FROM tb_systemLogs
DELETE FROM tb_Ticket

DBCC CHECKIDENT ('tb_loggedAdmin', RESEED, 0)

SELECT COUNT(*) AS 'countEvents'
								FROM tb_EventInfo EI JOIN tb_Schedule S 
								ON EI.scheduleID = s.scheduleID
								WHERE ((venueName = 'SMX' and isPastEvent != 1) and (EI.scheduleID != 1))
								and (((('2017-10-23' between dateStart and dateEnd) or ('2017-10-24' between dateStart and dateEnd)) 
								and ((CAST('10:00' AS time) BETWEEN timeStart and timeEnd) or (CAST('14:00' AS time) BETWEEN 
								timeStart and timeEnd))) or (((dateStart between '2017-10-25' and '2017-10-25') or (dateEnd between 
								'2017-10-25' and '2017-10-25')) and ((timeStart BETWEEN CAST('10:00' AS time) and CAST('14:00' AS 
								time)) or (timeEnd  BETWEEN CAST('10:00' AS time) and CAST('14:00' AS time)))))

								SELECT COUNT(*) AS 'countEvents'
                                                              FROM tb_EventInfo EI JOIN tb_Schedule S 
                                                              ON EI.scheduleID = s.scheduleID
                                                              WHERE (venueName = 'SMX' and isPastEvent != 1)
                                                              and ((('2017-10-24' between dateStart 
                                                              and dateEnd)) and ((((CAST('12:30' AS time) BETWEEN timeStart 
                                                              and timeEnd) or (CAST('13:00' AS time) BETWEEN timeStart and timeEnd))) 
                                                              or ((timeStart BETWEEN CAST('12:30' AS time) and CAST('13:00' AS time)) 
                                                              or (timeEnd  BETWEEN CAST('12:30' AS time) and CAST('13:00' AS time)))))


SELECT eventName, dateStart, dateEnd, 
CONVERT(varchar(15),timeStart,100) AS 'timeStart', 
CONVERT(varchar(15),timeEnd,100) AS 'timeEnd', 
venueName, ticketCapacity, ticketBought
FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
WHERE (DATEDIFF(DAY, GETDATE(), dateStart) IN (SELECT TOP 1 datediff(DAY, getdate(), dateStart) 
											   FROM tb_schedule S JOIN tb_EventInfo E
											   ON S.scheduleID = E.scheduleID
											   WHERE (isPastEvent != 1 AND datediff(DAY, getdate(), dateStart) >= 0) AND (CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108)) !< GETDATE())
										       ORDER BY 1 ASC)) AND (isPastEvent != 1 AND CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108)) !< GETDATE())
ORDER BY CONVERT(varchar(15),timeStart,100) ASC


																  select * from tb_EventInfo

UPDATE tb_EventInfo  
SET isPastEvent = '1'
WHERE scheduleID IN (SELECT S.scheduleID
				     FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
                     WHERE CONVERT(DATETIME, CONVERT(CHAR(8), dateEnd, 112)+ ' ' +CONVERT(CHAR(8), timeEnd, 108)) <= GETDATE() 
                     AND CONVERT(DATETIME, CONVERT(CHAR(8), dateEnd, 112)+ ' ' +CONVERT(CHAR(8), timeEnd, 108)) < GETDATE())

SELECT  CONVERT(DATETIME, CONVERT(CHAR(8), dateEnd, 112)+ ' ' +CONVERT(CHAR(8), timeEnd, 108))
FROM tb_Schedule

SELECT * FROM tb_Schedule


SELECT COUNT(*) AS 'countEvent'
FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
WHERE S.scheduleID = 1 AND (SELECT CONVERT(DATETIME, CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108))
							          FROM tb_schedule S JOIN tb_EventInfo E ON S.scheduleID = E.scheduleID
							          WHERE S.scheduleID = 1) < GETDATE()


SELECT EI.scheduleID, eventName, [description], 
dateStart, dateEnd, timeStart, timeEnd, 
venueName, ticketCapacity, ticketAmount, fbGroupCode 
FROM tb_EventInfo EI JOIN tb_Schedule S 
ON EI.scheduleID = s.scheduleID
WHERE isPastEvent != 1
ORDER BY CONVERT(CHAR(8), dateStart, 112)+ ' ' +CONVERT(CHAR(8), timeStart, 108) ASC

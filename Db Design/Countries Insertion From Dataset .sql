Select * from [Countries Data Set]; 

Insert Into Countries (CountryName) -- fill table with data from data set 
select [Countries Data Set].Country from [Countries Data Set] 

Select * from Countries
where CountryName like 'I%' ;

Delete Countries 
where CountryName = 'Israel'


if not exists (select 1 from dbo.[Students])
begin
 insert into dbo.[Students](fname, lname, age, dateOfEnrollment, grade, GPA)
  values 
    ('Howard', 'LoveCraft', 14, '9/1/2020', 9, 3.00),
    ('Mary', 'Shelly', 14, '9/1/2020', 9, 3.20),
    ('Dean', 'Koontz', 14, '9/1/2020', 9, 3.12),
    ('Isaac', 'Asimov', 15, '9/1/2019', 9, 3.00),
    ('Arthur', 'Clarke', 15, '9/1/2019', 9, 3.20),
    ('Howard', 'Wells', 15, '9/1/2019', 9, 3.12);
end
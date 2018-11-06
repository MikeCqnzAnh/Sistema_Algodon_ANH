select distinct o.name as Nombre, o.xtype as Tipo
  from syscomments c
       inner join sysobjects o on c.id=o.id
 where c.text like '%tierras%'
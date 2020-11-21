select baleid,strength,26-convert(int,strength) as diferencia , (26-convert(int,strength))+strength as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from hvidetalle where strength < 26 and lotid <= 184
union
select baleid,strength,convert(int,strength)-26 as diferencia , strength- (convert(int,strength)-26) as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from hvidetalle where strength >= 27 and strength < 28 and lotid <= 184
union
select baleid,strength,convert(int,strength)-27 as diferencia , strength- (convert(int,strength)-27) as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from hvidetalle where strength >=28 and strength < 29 and lotid <= 184
union
select baleid,strength,convert(int,strength)-28 as diferencia , strength- (convert(int,strength)-28) as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from hvidetalle where strength >=29 and strength < 30 and lotid <= 184
union
select baleid,strength,convert(int,strength)-29 as diferencia , strength- (convert(int,strength)-29) as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from hvidetalle where strength >=30 and strength < 31 and lotid <= 184
union
select baleid,strength,convert(int,strength)-29 as diferencia , strength- (convert(int,strength)-29) as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from hvidetalle where strength >=31 and strength < 34 and lotid <= 184
union
select baleid,strength,convert(int,strength)-30 as diferencia , strength- (convert(int,strength)-30) as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from hvidetalle where strength >=34 and strength < 43 and lotid <= 184



select baleid,strength,26-convert(int,strength) as diferencia , (26-convert(int,strength))+strength as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from CalculoClasificacion where strength < 26 
union
select baleid,strength,convert(int,strength)-26 as diferencia , strength- (convert(int,strength)-26) as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from CalculoClasificacion where strength >= 27 and strength < 28 
union
select baleid,strength,convert(int,strength)-27 as diferencia , strength- (convert(int,strength)-27) as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from CalculoClasificacion where strength >=28 and strength < 29 
union
select baleid,strength,convert(int,strength)-28 as diferencia , strength- (convert(int,strength)-28) as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from CalculoClasificacion where strength >=29 and strength < 30 
union
select baleid,strength,convert(int,strength)-29 as diferencia , strength- (convert(int,strength)-29) as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from CalculoClasificacion where strength >=30 and strength < 31 
union
select baleid,strength,convert(int,strength)-29 as diferencia , strength- (convert(int,strength)-29) as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from CalculoClasificacion where strength >=31 and strength < 34 
union
select baleid,strength,convert(int,strength)-30 as diferencia , strength- (convert(int,strength)-30) as Resultado,CONVERT(INT,-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB) as SCI_n, SCI  from CalculoClasificacion where strength >=34 and strength < 43 

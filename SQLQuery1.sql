﻿INSERT INTO TB_PERFIL(ID, NOME)
VALUES
(NEWID(), 'OPERADOR'),
(NEWID(), 'ADMINISTRADOR');

GO
SELECT * FROM TB_PERFIL;
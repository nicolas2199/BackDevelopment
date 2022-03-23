# Crear el Proyecto

```
dotnet new console --framework net5.0 -n PrintMultiples
```
# Descargar Nugets y restaurar el proyecto

```
dotnet restore .\PrintPrimes.csproj
```

# Compilar y Construir el ejecutable

```
dotnet build .\PrintPrimes.csproj
```

# Ejecutar el Proyecto

```
dotnet run .\PrintPrimes.csproj
```
# Notas
## PrintPrimes (1.4)
- No tiene Errores Ni Warnings (0.5)      = 0.0 => Tiene un Warning
- No tiene Codigo Innecesario  (0.5)      = 0.0 => tiene un catch Innecesario
- Funciona y Cumple con el Objetivo (1.5) = 0.0 => No Cumple con el objetivo
- El codigo Es Entendible (1.0)           = 0.5 => Parcialmente entendible
- Cumple con el Codigo Limpio (1.5)       = 0.9 => Tiene Nociones pero no estan aplicando Clean Code
  Los Nombres de las variables y Funciones: (0.1/ cada una)
  - Revelan la intencion, es decir se sabe que hacen o que almacenan? = X
  - Los Nombres son claros o son confusos?                            = OK
  - Son Pronunciables                                                 = OK
  - Son buscables (Numero Magicos o No hay Constantes)?               = X
  - tiene notaciones innecesarias IntCodigo, strData) ?               = OK
  - Usan Sustantivos para Clases y Verbos para Metodos?               = OK
  - Una sola palabra por concepto?                                    = OK
  - No usan combinaciones o juegos de palabras?                       = OK
  - No tiene copntexto adicional o superfluo?                         = OK
  - Usan Datos del dominio, del negocio, problema o solucion ?        = OK
  - Cumplen con el Estandar de Pascal y Camel Case?                   = OK
  Las Funciones
  - Son pequeñas y su logica esta bien separada?                      = X
  - Las Funciones hacen una sola cosa?                                = X
  - Tieen Logica de Retorno directo y correcto o hay If para retornar = X
  - Existen Multiples If anidados o hay instrucciones Switch          = X  


## Print Multiples (3.7).0)
- No tiene Errores Ni Warnings (0.5)      = 0.5 => No tiene Errores Ni Warnings
- No tiene Codigo Innecesario  (0.5)      = 0.0 => Las Vbles de validate no son Necesarias
- Funciona y Cumple con el Objetivo (1.5) = 1.4 => no se elimino la ultima coma al final
- El codigo Es Entendible (1.0)           = 1.0
- Cumple con el Codigo Limpio (1.5)       = 0.8 => NO 
  Los Nombres de las variables y Funciones: (0.1/ cada una)
  - Revelan la intencion, es decir se sabe que hacen o que almacenan? = X => GenerateList de que?
  - Los Nombres son claros o son confusos?                            = X = n1 y n2 ?
  - Son Pronunciables                                                 = OK
  - Son buscables (Numero Magicos o No hay Constantes)?               = X => Hoy puede ser Three, mañana puede ser Two and Seven
  - tiene notaciones innecesarias IntCodigo, strData) ?               = OK
  - Usan Sustantivos para Clases y Verbos para Metodos?               = OK
  - Una sola palabra por concepto?                                    = OK
  - No usan combinaciones o juegos de palabras?                       = OK
  - No tiene copntexto adicional o superfluo?                         = OK
  - Usan Datos del dominio, del negocio, problema o solucion ?        = OK
  - Cumplen con el Estandar de Pascal y Camel Case?                   = X => los metodos son en Pascal Case
  Las Funciones
  - Son pequeñas y su logica esta bien separada?                      = X
  - Las Funciones hacen una sola cosa?                                = X
  - Tieen Logica de Retorno directo y correcto o hay If para retornar = X
  - Existen Multiples If anidados o hay instrucciones Switch          = OK

## Debugging (5.0)
- No tiene Errores Ni Warnings (0.5)      = 0.5
- No tiene Codigo Innecesario  (0.5)      = 0.5
- Funciona y Cumple con el Objetivo (1.5) = 1.5
- El codigo Es Entendible (1.0)           = 1.0
- Cumple con el Codigo Limpio (1.5)       = 1.5
  Los Nombres de las variables y Funciones: (0.1/ cada una)
  - Revelan la intencion, es decir se sabe que hacen o que almacenan? = OK
  - Los Nombres son claros o son confusos?                            = OK
  - Son Pronunciables                                                 = OK
  - Son buscables (Numero Magicos o No hay Constantes)?               = OK
  - tiene notaciones innecesarias IntCodigo, strData) ?               = OK
  - Usan Sustantivos para Clases y Verbos para Metodos?               = OK
  - Una sola palabra por concepto?                                    = OK
  - No usan combinaciones o juegos de palabras?                       = OK
  - No tiene copntexto adicional o superfluo?                         = OK
  - Usan Datos del dominio, del negocio, problema o solucion ?        = OK
  - Cumplen con el Estandar de Pascal y Camel Case?                   = OK
  Las Funciones
  - Son pequeñas y su logica esta bien separada?                      = OK
  - Las Funciones hacen una sola cosa?                                = OK
  - Tieen Logica de Retorno directo y correcto o hay If para retornar = OK
  - Existen Multiples If anidados o hay instrucciones Switch          = OK 

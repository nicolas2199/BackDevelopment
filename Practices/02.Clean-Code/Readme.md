# Crear el Proyecto

```
dotnet new console --framework net5.0 -n PrintMultiples
````
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
## PrintPrimes
- No tiene Errores Ni Warnings (0.5)      = 0.0 => Tiene un Warning
- No tiene Codigo Innecesario  (0.5)      = 0.0 => tiene un catch Innecesario
- Funciona y Cumple con el Objetivo (1.0) = 0.0 => No Cumple con el objetivo
- El codigo Es Entendible (1.0)           = 0.5 => Parcialmente entendible
- Cumple con el Codigo Limpio (2.0)       = 1.0 => Tiene Nociones pero no estan aplicando Clean Code

## Print Multiples
- No tiene Errores Ni Warnings (0.5)      = 0.5
- No tiene Codigo Innecesario  (0.5)      = 0.0 => Las Vbles de validate no son Necesarias
- Funciona y Cumple con el Objetivo (1.0) = 0.8 => no se elimino la ultima coma al final
- El codigo Es Entendible (1.0)           = 1.0
- Cumple con el Codigo Limpio (2.0)       = 1.2 => NO 
    - GenerateList? de que?
    - No es parametrizable, hoy son de 3 y 5 mañana pueden ser de 2 y 7 y los numeros de 30 al 300 que pasa?
    - Toas las condiciones se evaluan, deberia separase esa evaluacion en otra funcion
    - La condicion del ValidateIsMultiple puede simplifircarse en lugar de retornar true o false


## Debugging
- No tiene Errores Ni Warnings (0.5)      = 
- No tiene Codigo Innecesario  (0.5)      = 
- Funciona y Cumple con el Objetivo (1.0) = 
- El codigo Es Entendible (1.0)           = 
- Cumple con el Codigo Limpio (2.0)       = 

# Contar frecuencia de caracteres (C#)

## Descripción

Este programa en C# para consola permite analizar una cadena de texto y calcular cuántas veces aparece cada carácter alfanumérico (letras y números).

El resultado se devuelve como una colección de objetos con el carácter y su frecuencia.

---

## Reglas del problema

* No diferencia entre mayúsculas y minúsculas
* No diferencia entre letras con tilde y sin tilde
* Solo cuenta caracteres alfanuméricos (letras y números)
* No modifica el texto original
* El resultado se ordena alfabéticamente

---

## Ejemplo

### Entrada

```id="1c0qwl"
Hoy ya es día 10
```

### Salida

```id="c2m9av"
{ Car = '0', Veces = 1 }
{ Car = '1', Veces = 1 }
{ Car = 'a', Veces = 2 }
{ Car = 'd', Veces = 1 }
{ Car = 'e', Veces = 1 }
{ Car = 'h', Veces = 1 }
{ Car = 'i', Veces = 1 }
{ Car = 'o', Veces = 1 }
{ Car = 's', Veces = 1 }
{ Car = 'y', Veces = 2 }
```

---

## Funcionamiento

El programa:

1. Convierte el texto a minúsculas
2. Elimina tildes usando normalización Unicode
3. Filtra solo letras y números
4. Cuenta la frecuencia con un `Dictionary`
5. Convierte el resultado a una lista de objetos
6. Ordena alfabéticamente por carácter

---

## Estructura

* `ContarFrecuencia()` → lógica principal
* `RemoverTildes()` → normaliza texto
* Clase `Frecuencia` → modelo de datos

---

## Tecnologías usadas

* C#
* .NET
* Consola

---

## Autor

Felipe Corredor
Ejercicio de análisis de texto
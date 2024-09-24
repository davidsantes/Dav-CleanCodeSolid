# Resumen de "Clean Code" - Robert C. Martin

## 1. ¿Qué es Código Limpio?
El **código limpio** es aquel que es fácil de leer, entender y modificar. No solo debe funcionar correctamente, sino que debe ser mantenible y escalable a lo largo del tiempo. Un código limpio debe seguir principios que permitan que cualquier desarrollador pueda trabajar con él fácilmente.

Como dijo Martin Fowler:
> "Cualquiera puede escribir código que una máquina entienda. Los buenos programadores escriben código que los humanos puedan entender."
> 
> — Martin Fowler


## 2. Principios Clave del Código Limpio

### Nombres Significativos
- Los nombres de variables, funciones y clases deben ser **claros y descriptivos**.
- Deben reflejar su propósito y facilitar la comprensión del código.

### Funciones Pequeñas
- Las funciones deben ser **cortas** y realizar **solo una tarea**.
- El código dentro de una función debe estar al mismo nivel de abstracción.

### Evitar Comentarios Innecesarios
- El código debe ser **autodescriptivo** para no necesitar comentarios.
- Los comentarios deben usarse para aclarar aspectos complejos o proporcionar contexto, no para explicar lo que ya debe ser evidente en el código.

### Formateo Consistente
- Mantener un estilo coherente en cuanto a **espaciado, indentación y estructura**.
- El código bien organizado es más fácil de leer y mantener.

## 3. Manejo de Errores
- El manejo de errores debe ser **claro y consistente**.
- Usar excepciones en lugar de códigos de error o condiciones de control complejas.
- Evitar estructuras anidadas complicadas al manejar errores.

## 4. Testing
- El código limpio debe ser **fácil de probar**.
- Aboga por el uso de **Test-Driven Development (TDD)**: escribir las pruebas antes del código.
- Las pruebas unitarias deben ser rápidas, aisladas y confiables, cubriendo los casos más importantes del código.

## 5. Clases y Objetos
### Clases Cohesivas
- Las clases deben tener una **única responsabilidad**. 
- La cohesión es clave: todas las funciones de una clase deben estar relacionadas con esa responsabilidad.

### Dependencias
- Las clases deben tener **mínimas dependencias externas**.
- Usar la **inyección de dependencias** para mejorar la modularidad y facilitar el testeo.

## 6. Refactorización
- La **refactorización** es esencial para mantener el código limpio.
- Debe realizarse de manera frecuente, ajustando el código para que sea más legible y eficiente sin cambiar su funcionalidad.
- Es importante mantener el código cubierto por **pruebas automatizadas** para asegurar que no se introduzcan errores al refactorizar.

## 7. Reglas de Oro del Código Limpio
- **Deja el código más limpio de lo que lo encontraste**.
- **El código es su propia documentación**, no dependas de comentarios extensos.
- **Minimiza la complejidad**: escribe código simple y directo.

## 8. En resumen...
Escribir código limpio requiere **disciplina y esfuerzo constante**. No basta con que el código funcione, debe ser **comprensible y fácil de mantener**. Un código limpio facilita la colaboración, reduce el costo de mantenimiento y mejora la calidad general del software.

La idea central es que todo desarrollador tiene la responsabilidad ética de escribir código limpio, ya que este mejora tanto la productividad del equipo como la calidad de los productos a largo plazo.

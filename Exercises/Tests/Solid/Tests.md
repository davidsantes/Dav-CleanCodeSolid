# Test: Principios SOLID

### 1. En el principio de **Responsabilidad Única (SRP)**, ¿cuál de las siguientes afirmaciones es correcta?
- A) Una clase debe tener exactamente un método público.
- B) Una clase debe ser responsable de una única tarea o razón de cambio.
- C) Una clase solo puede trabajar con un objeto a la vez.
- D) Una clase no debe ser modificada nunca después de su creación.

### 2. En el principio de **Abierto/Cerrado (OCP)**, ¿qué se entiende por "cerrado" en una clase?
- A) La clase está cerrada para ser utilizada por otros módulos.
- B) La clase está cerrada para ser heredada.
- C) La clase está cerrada a modificaciones en su código fuente, pero abierta a extensiones.
- D) La clase está cerrada a la creación de instancias.

### 3. Según el principio de **Sustitución de Liskov (LSP)**, ¿cuál de las siguientes violaría este principio?
- A) Una subclase sobrescribe un método de la clase base para mejorar su rendimiento.
- B) Una subclase hereda de la clase base, pero no implementa algunos métodos.
- C) Una subclase es utilizada en lugar de su clase base sin alterar el comportamiento del sistema.
- D) Una subclase añade nuevas funcionalidades a los métodos heredados de la clase base.

### 4. Respecto al principio de **Inversión de Dependencias (DIP)**, ¿cuál de las siguientes afirmaciones es incorrecta?
- A) Los módulos de alto nivel no deben depender de los de bajo nivel.
- B) Ambos módulos deben depender de abstracciones.
- C) Las abstracciones no deben depender de los detalles, pero los detalles sí pueden depender de abstracciones.
- D) Es aceptable que una clase de bajo nivel dependa directamente de una clase concreta de alto nivel.

### 5. ¿Cuál de las siguientes situaciones describe correctamente una violación del principio de **Segregación de Interfaces (ISP)**?
- A) Una clase implementa una interfaz, pero no utiliza todos sus métodos.
- B) Una interfaz es implementada por múltiples clases sin sobrescribir ningún método.
- C) Una interfaz pequeña está dividida en varias interfaces más especializadas.
- D) Una clase utiliza varias interfaces para dividir sus responsabilidades.

### 6. ¿Cómo puede el principio **Abierto/Cerrado (OCP)** contribuir a la aplicación de patrones de diseño como el **Patrón Estrategia**?
- A) El patrón estrategia permite modificar directamente el comportamiento de las clases existentes.
- B) El patrón estrategia permite extender el comportamiento de una clase sin modificar su implementación base.
- C) El patrón estrategia elimina la necesidad de usar clases base o interfaces.
- D) El patrón estrategia fuerza la creación de múltiples instancias de una clase base.

### 7. Si estás aplicando el principio de **Inversión de Dependencias (DIP)**, ¿cuál de los siguientes enfoques sería inapropiado?
- A) Usar interfaces para definir comportamientos comunes entre clases de diferentes niveles.
- B) Utilizar la inyección de dependencias para desacoplar módulos de alto nivel de los detalles.
- C) Hacer que los módulos de alto nivel dependan directamente de clases concretas de bajo nivel.
- D) Definir abstracciones que encapsulen los detalles de implementación.

### 8. Considerando el principio de **Sustitución de Liskov (LSP)**, ¿cuál de las siguientes situaciones sería una señal de una posible violación del principio?
- A) Una subclase ignora un método de la clase base y lanza una excepción cuando este es invocado.
- B) Una subclase añade nuevos métodos sin modificar los de la clase base.
- C) Una subclase extiende las funcionalidades de la clase base sin alterar su comportamiento.
- D) Una subclase reutiliza el comportamiento de la clase base sin realizar modificaciones.

### 9. ¿Cómo el principio de **Segregación de Interfaces (ISP)** ayuda a mejorar la mantenibilidad del software?
- A) Obliga a las clases a implementar todas las funcionalidades de una interfaz grande.
- B) Promueve la creación de interfaces grandes y reutilizables para todas las clases.
- C) Permite que las clases implementen solo las interfaces necesarias, reduciendo la necesidad de métodos no utilizados.
- D) Permite que una clase utilice múltiples interfaces pequeñas, generando acoplamiento innecesario.

### 10. ¿Qué enfoque práctico suele aplicarse para respetar el principio de **Responsabilidad Única (SRP)**?
- A) Dividir una clase en varias subclases, cada una con un método diferente.
- B) Refactorizar una clase cuando sus responsabilidades se multiplican, dividiéndola en componentes más pequeños con una única responsabilidad.
- C) Asegurarse de que una clase solo contenga métodos relacionados con acceso a la base de datos.
- D) Crear una clase con múltiples responsabilidades que puedan ser gestionadas internamente.

---

## Respuestas correctas:
1. B) Una clase debe ser responsable de una única tarea o razón de cambio.
2. C) La clase está cerrada a modificaciones en su código fuente, pero abierta a extensiones.
3. B) Una subclase hereda de la clase base, pero no implementa algunos métodos.
4. D) Es aceptable que una clase de bajo nivel dependa directamente de una clase concreta de alto nivel.
5. A) Una clase implementa una interfaz, pero no utiliza todos sus métodos.
6. B) El patrón estrategia permite extender el comportamiento de una clase sin modificar su implementación base.
7. C) Hacer que los módulos de alto nivel dependan directamente de clases concretas de bajo nivel.
8. A) Una subclase ignora un método de la clase base y lanza una excepción cuando este es invocado.
9. C) Permite que las clases implementen solo las interfaces necesarias, reduciendo la necesidad de métodos no utilizados.
10. B) Refactorizar una clase cuando sus responsabilidades se multiplican, dividiéndola en componentes más pequeños con una única responsabilidad.

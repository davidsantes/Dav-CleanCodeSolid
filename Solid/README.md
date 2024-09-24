# Principios SOLID

Los **Principios SOLID** son un conjunto de cinco principios de diseño de software orientado a objetos, formulados por Robert C. Martin (Uncle Bob). Estos principios buscan mejorar la calidad, mantenibilidad y flexibilidad del código.

## 1. S - Principio de Responsabilidad Única (Single Responsibility Principle - SRP)
Cada clase o módulo debe tener una única razón para cambiar, es decir, debe tener una única responsabilidad. Una clase debe ocuparse de una tarea específica para evitar que tenga múltiples responsabilidades y dependencias innecesarias.

**Objetivo**: que nuestras clases hagan una sola cosa. De esta manera podemos asegurar que esta funcionalidad la hace muy bien (por ejemplo, con testing).

## 2. O - Principio Abierto/Cerrado (Open/Closed Principle - OCP)
El software debe estar **abierto para extensión**, pero **cerrado para modificación**. Debemos poder añadir nuevas funcionalidades sin modificar el código existente, lo que minimiza el riesgo de introducir errores.
Las técnicas más comunes para cumplir con este principio son la **herencia** y el **polimorfismo**.

**Objetivo**: conseguir que nuestra aplicación esté protegida contra cambios en el código existente (que sea difícil de romper) y que sea fácil de extender.)

## 3. L - Principio de Sustitución de Liskov (Liskov Substitution Principle - LSP)
Los objetos de una subclase deben poder reemplazar a los objetos de su clase base sin afectar la funcionalidad del programa. Las clases derivadas deben ser intercambiables con sus clases base, respetando su comportamiento.

**Objetivo**: Asegurar que una subclase pueda ser utilizada en lugar de su clase base sin alterar el correcto funcionamiento del sistema. Esto promueve la reutilización de código y la robustez del software, permitiendo que las clases derivadas extiendan la funcionalidad de las clases base sin introducir errores o comportamientos inesperados.

## 4. I - Principio de Segregación de Interfaces (Interface Segregation Principle - ISP)
Es mejor tener varias interfaces pequeñas y específicas que una interfaz general y grande. Las clases no deben estar obligadas a implementar interfaces que no utilizan, evitando la sobrecarga con métodos innecesarios.

**Objetivo**: Asegurar que las clases solo dependan de los métodos que realmente utilizan, promoviendo un diseño más limpio y manejable. Esto reduce la complejidad y facilita el mantenimiento del código, ya que los cambios en una interfaz no afectarán a las clases que no la implementan completamente.

## 5. D - Principio de Inversión de Dependencias (Dependency Inversion Principle - DIP)
Los módulos de alto nivel no deben depender de módulos de bajo nivel. Ambos deben depender de **abstracciones**. Además, las **abstracciones no deben depender de detalles**, sino que los detalles deben depender de abstracciones. Esto promueve un diseño flexible y desacoplado.

**Objetivo**: Promover un diseño de software que sea flexible y desacoplado basado en la abstracción, permitiendo que los módulos de alto nivel y de bajo nivel evolucionen independientemente. Esto facilita la prueba y el mantenimiento del código, ya que los cambios en los detalles de implementación no afectan a las abstracciones y viceversa.

---
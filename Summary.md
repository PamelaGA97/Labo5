**Problema:**
El problema consiste en implementar una calculadora que sea capaz de realizar cualquier operacion matematica con la cantidad de numeros que se desee, la implementacion debe ser escalable, es decir, que durante el tiempo yo se deberia poder añadir cualquier operacion sin mucha complicacion.

**Patron:**
El patron implementado fue el de strategy el que nos permite tener diferentes estrategias de operaciones matematicas como ser las mas basicas suma, resta, division y multiplicacion, y que el cliente pueda usar la que desee.
Una de las ventajas de este patron es que se puede añadir mas estrategias de operacion sin necesidad de cambiar mucho codigo, simplemente aumentando la nueva estrategia de operacion que implemente de la interfaz IMathOperationStrategy , lo cual hace que la aplicacion sea escalable.
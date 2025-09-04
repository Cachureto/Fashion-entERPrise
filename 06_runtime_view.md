# Vista en Tiempo de Ejecución

## Escenario Crítico: Registrar un Producto

Este escenario describe cómo se gestiona el registro de un nuevo producto en el ERP.

### Flujo
1. El usuario ingresa los datos del producto en el **Frontend**.
2. El **Backend** valida la información.
3. El **Backend** guarda el producto en la **Base de Datos**.
4. El sistema actualiza el inventario y notifica al usuario.

### Diagrama de Secuencia
![Diagrama de Secuencia](./images/sequence_register_product.png)

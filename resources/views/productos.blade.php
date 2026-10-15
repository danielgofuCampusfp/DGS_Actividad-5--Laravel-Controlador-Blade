<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Listado de Productos</title>
</head>
<body>

    <h1>Catálogo de Productos</h1>

    @foreach($listaProductos as $producto)
        <div class="card">
            <h3>{{ $producto['nombre'] }}</h3>
            <p>Precio: <strong>{{ $producto['precio'] }}€</strong></p>
        </div>
    @endforeach

</body>
</html>
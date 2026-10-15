<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ProductoController extends Controller
{
    public function index()
    {
        // Creamos un array asociativo simple con los productos
        $productos = [
            ['nombre' => 'Portátil ASUS Rog', 'precio' => 1200],
            ['nombre' => 'Ratón Logi MX Master', 'precio' => 100],
            ['nombre' => 'Teclado Mecánico Keychron', 'precio' => 150]
        ];

        // Enviamos el array a la vista
        return view('productos', ['listaProductos' => $productos]);
    }
}

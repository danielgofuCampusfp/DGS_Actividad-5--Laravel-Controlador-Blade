<?php

namespace App\Http\Controllers;

abstract class Controller
{
     public function index()
    {
        $productos = [
            ['nombre' => 'Portátil ASUS Rog', 'precio' => 1200],
            ['nombre' => 'Ratón Logi MX Master', 'precio' => 100],
            ['nombre' => 'Teclado Mecánico Keychron', 'precio' => 150]
        ];

        return view('productos', ['listaProductos' => $productos]);
    }
}

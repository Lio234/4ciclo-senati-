from django.shortcuts import *
from .models import Producto
from .forms import producto_form  # Corregir la importación del formulario

def Mostrar(request):
    productos = Producto.objects.all()
    return render(request, "index.html", {"productos": productos})

def agregar_producto(request):
    if request.method == 'POST':
        form = producto_form(request.POST)  # Corregir la instanciación del formulario
        if form.is_valid():
            form.save()
            return redirect('mostrar')
    else:
        form = producto_form()  # Corregir la instanciación del formulario
    return render(request, 'agregar_producto.html', {'form': form})

def editar_producto(request, pk):
    producto = get_object_or_404(Producto, pk=pk)
    if request.method == 'POST':
        form = producto_form(request.POST, instance=producto)
        if form.is_valid():
            form.save()
            return redirect('mostrar')
    else:
        form = producto_form(instance=producto)
    return render(request, 'editar_producto.html', {'form': form})

def eliminar_producto(request, pk):
    producto = get_object_or_404(Producto, pk=pk)
    if request.method == 'POST':
        producto.delete()
        return redirect('mostrar')
    return render(request, 'confirmar_eliminar.html', {'producto': producto})

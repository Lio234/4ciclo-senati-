from django.shortcuts import render, redirect
from .models import Mascota
from .forms import MascotaForm

def mostrar(request):
    mascotas = Mascota.objects.all()
    return render(request, 'index.html', {'mascotas': mascotas})

def agregar_mascota(request):
    if request.method == 'POST':
        form = MascotaForm(request.POST)
        if form.is_valid():
            form.save()
            # Después de guardar la mascota, redirigir al usuario a la página mostrar para ver la tabla actualizada
            return redirect('mostrar')
    else:
        form = MascotaForm()
    return render(request, 'agregar_mascota.html', {'form': form})

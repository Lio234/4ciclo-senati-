from django import forms
from .models import Producto

class producto_form(forms.ModelForm):
    class Meta:
        model = Producto
        fields = ['descripcion', 'categoria', 'precio', 'stock']
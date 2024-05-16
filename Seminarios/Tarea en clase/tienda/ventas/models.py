from django.db import models

class Producto(models.Model):
    id = models.AutoField(primary_key=True)
    descripcion = models.CharField(max_length=20)
    categoria = models.CharField(max_length=20)
    precio = models.FloatField()
    stock = models.IntegerField()

    def __str__(self):
        return self.descripcion  # Suponiendo que 'descripcion' es el campo que deseas mostrar al imprimir el objeto Producto

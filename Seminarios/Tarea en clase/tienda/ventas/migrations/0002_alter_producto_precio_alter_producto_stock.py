# Generated by Django 5.0.3 on 2024-05-07 15:19

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('ventas', '0001_initial'),
    ]

    operations = [
        migrations.AlterField(
            model_name='producto',
            name='precio',
            field=models.FloatField(),
        ),
        migrations.AlterField(
            model_name='producto',
            name='stock',
            field=models.IntegerField(),
        ),
    ]
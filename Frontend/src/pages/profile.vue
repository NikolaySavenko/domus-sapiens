<template>
    <q-header align="center" class="bg-positive text-black">
        <p class="text-h4">Профиль</p>
        <q-btn round flat align="center" class="buttonintop bg-primary">
            plus
        </q-btn>
        <p class="text-h4">Имя Фамилия</p>
    </q-header>
    <div class="alignment" >
        <q-card class="data">
            <q-card-actions align="left" class="bg-accent">
              Пароль
            </q-card-actions>
        </q-card>
        <q-card class="data">
            <q-card-actions align="left" class="bg-accent">
              Личные данные
            </q-card-actions>
        </q-card>
        <q-card class="data">
            <q-card-actions align="left" class="bg-accent">
              чтото
            </q-card-actions>
        </q-card>
        <q-card class="data">
            <q-card-actions align="left" class="bg-accent">
              чтото
            </q-card-actions>
        </q-card>
        <q-card class="data">
            <q-card-actions align="left" class="bg-accent">
              Выход
            </q-card-actions>
        </q-card>
    </div>
</template>

<script lang="ts">
</script>

<style land="scss" scoped>
.data
{
    border-radius: 16px;
    margin-top: 9px;
}
.alignment
{
    width: 90%;
    margin-left: auto;
    margin-right: auto;
}
.buttonintop
{
    width: 150px;
    height: 150px;
}
</style>

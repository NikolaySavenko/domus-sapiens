<template>
    <q-header align="center" class="bg-positive text-black">
        <div align="center"><img src="../assets/settings.png" class="heading"></div>
    </q-header>
    <div class="alignment" >
        <q-card class="data bg-positive">
            <q-card-actions class="q-pt-lg q-pl-md">
              Ночная тема
            </q-card-actions>
        </q-card>
        <q-card class="data bg-positive">
            <q-card-actions class="q-pt-lg q-pl-md">
              Уведомления
            </q-card-actions>
        </q-card>
        <q-card class="data bg-positive">
            <q-card-actions class="q-pt-lg q-pl-md">
              Учетные записи
            </q-card-actions>
        </q-card>
    </div>
</template>

<script lang="ts">
</script>

<style land="scss" scoped>
.data
{
    height: 72px;
    border-radius: 16px;
    margin-top: 9px;
}
.alignment
{
    width: 90%;
    margin-left: auto;
    margin-right: auto;
}
.heading
{
    width: 150px;
    height: 150px;
}
</style>
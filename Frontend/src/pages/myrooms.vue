<template>
    <q-header align="center" class="bg-secondary text-black">
        <p class="text-h4">Мои комнаты</p>
    </q-header>
    <div class="alignment" >
        <q-card class="data bg-accent">
            <q-card-actions class="q-pt-lg q-pl-md">
              Прихожая
            </q-card-actions>
        </q-card>
        <q-card class="data bg-accent">
            <q-card-actions class="q-pt-lg q-pl-md">
              Спальная комната
            </q-card-actions>
        </q-card>
        <q-card class="data bg-accent">
            <q-card-actions class="q-pt-lg q-pl-md">
              Кухня
            </q-card-actions>
        </q-card>
        <q-card class="data bg-accent">
            <q-card-actions class="q-pt-lg q-pl-md">
              Гостинная
            </q-card-actions>
        </q-card>
    </div>
</template>

<script lang="ts">
import { defineComponent, ref } from "vue"
export default defineComponent({
})
</script>

<style land="scss" scoped>
.data {
    height: 72px;
    border-radius: 16px;
    margin-top: 9px;
}
.alignment {
    width: 90%;
    margin-left: auto;
    margin-right: auto;
}

</style>
<template>
    <q-header align="center" class="bg-secondary text-black">
        <div align="center" class="text-h5 q-pt-md">Мои устройства</div>
    </q-header>
    <div class="alignment" >
        <q-card class="data bg-accent">
            <q-card-actions class="q-pt-lg q-pl-md">
              Умное устройство
            </q-card-actions>
        </q-card>
        <q-card class="data bg-accent">
            <q-card-actions class="q-pt-lg q-pl-md">
              Умное устройство
            </q-card-actions>
        </q-card>
        <q-card class="data bg-accent">
            <q-card-actions class="q-pt-lg q-pl-md">
              Умное устройство
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
.heading {
    width: 150px;
    height: 150px;
}
</style>
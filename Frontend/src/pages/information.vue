<template>
    <q-btn to="/" :unelevated="true" icon="arrow_back"/>
    <q-btn no-caps class=" alignment bg-accent">
        включить/выключить
    </q-btn>
    <q-btn no-caps class=" alignment bg-accent">
        выбор времени
    </q-btn>
    <q-btn no-caps class=" alignment bg-accent">
        добавить
    </q-btn>
    
</template>

<script lang="ts">
import { router } from "src/router"
import axios from 'axios';
import { defineComponent, ref } from "vue"
export default defineComponent({
    setup(){
        const currentRoute = router.currentRoute
        console.log(currentRoute.value.query.id)
        const id = ref(currentRoute.value.query.id)
        async function postRequest(id: string) {
            if(!id) throw `invalid id: ${id}`
            try {
                await axios.post(`http://140.238.172.28/api/Actions/${id}/Invoke`, {
                    test: "test"
                })
            }catch(e) {
            console.log(e)
            }
        }
        return {
            id,
            postRequest
        }
    }
})
//<div class="alignment" > </div>
/* <q-card class=" ">
            <q-btn no-caps class="data alignment bg-positive">
              включить/выключить
            </q-btn>
        </q-card>*/ 
</script>

<style land="scss" scoped>
.data {
    border-radius: 16px;
    border: 2px solid black;
    margin-top: 10px;
    width: 100%;
}
.alignment {
    width: 90%;
    margin-top: 9px;
    margin-left: 5%;
    margin-right: 5%;
}
.top-button {
    width: 150px;
    height: 150px;
}
</style>
<template>
    <q-btn to="/">стрелка назад</q-btn>
    <div class="data" >   
        <q-btn @click="postRequest(id)" no-caps class=" alignment bg-positive">
              включить/выключить
        </q-btn>
    </div>
        <q-card class="data bg-positive">
            <q-card-actions class="q-pt-lg q-pl-md">
              выбор времени
            </q-card-actions>
        </q-card>
        <q-card class="data bg-positive">
            <q-card-actions class="q-pt-lg q-pl-md">
              добавить
            </q-card-actions>
        </q-card>
    
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
    margin-top: 9px;
}
.alignment {
    width: 90%;
    margin: auto;
}
.top-button {
    width: 150px;
    height: 150px;
}
</style>
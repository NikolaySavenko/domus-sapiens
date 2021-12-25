<template>
<q-header class="bg-secondary text-h5 text-black text-center">
  Быстрые действия
</q-header>
    <div class="obj">
      <div class="row-button">
        <q-card :unelevated="false" v-for="data in buttons.data" :key="data" class="alignment">
          <q-btn @click="postRequest(data.actionActivityId)"
          no-caps :unelevated="false" align="center" class="button text-center bg-accent">
            {{ data.actionActivityName }}
          </q-btn>
        </q-card>
      </div>
    </div>
</template>

<script lang="ts">
import axios from 'axios';
import { defineComponent, ref, onMounted } from "vue"
export default defineComponent({
  setup() {
    let buttons = ref<any>([])
    onMounted(async () => {
        const response = await axios.get('https://domus-sapiens.ru/api/Actions')
        console.log(response)
        buttons.value = response
      })
      async function postRequest(id: string) {
        if(!id) throw `invalid id: ${id}`
        try {
          await axios.post(`https://domus-sapiens.ru/api/Actions/${id}/Invoke`, {
            test: "test"
          })
        }catch(e) {
          console.log(e)
        }
        }
    return {
      buttons,
      postRequest
    }
  }
});
</script>

<style land="scss" scoped>
.obj {
  margin-left: auto;
  margin-right: auto;
  width: 362px;
  height: 90%;
}
.row-button{
  display: flex;
  flex-wrap: wrap;
}
.button{
  width:157px;
  height:101px;
  border-radius: 17px;
  filter: drop-shadow(0px 5px 4px rgba(0, 0, 0, 0.25));
}
.alignment {
  margin-left: 12px;
  margin-right:12px;
  margin-top: 12px;
  border-radius: 17px;
}
</style>

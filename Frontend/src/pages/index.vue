<template>
    <div class="obj">
      <div class="row-button">
        <q-card v-for="data in buttons.data" :key="data" class="alignment">
          <q-btn :to="{ path: 'information', query: { id: data.actionActivityId } }" no-caps align="center" class="el text-center bg-primary">
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
        const response = await axios.get('http://140.238.172.28/api/Actions')
        console.log(response)
        buttons.value = response
      })
    return {
      buttons
    }
  }
});
</script>

<style land="scss" scoped>
.obj {
  margin-left: auto;
  margin-right: auto;
  width: 362px;
}
.row-button{
  display: flex;
  flex-wrap: wrap;
}
button{
  width: 100%;
  height:100%;
}
.el {
  width:157px;
  height:101px;
  border-radius: 17px;
  box-shadow: 0px 4px 8px rgba(0, 0, 0, 0.25);
}
.alignment {
  margin-left: 12px;
  margin-right:12px;
  margin-top: 12px;
  border-radius: 17px;
}
</style>

<template>
    <div class="obj">
      <div class="row-button">
        <q-card v-for="lol in data" :key="lol" class="alignment">
          <q-card-actions align="center" class="el text-center bg-primary">
            {{ lol.ActionActivityName }}
          </q-card-actions>
        </q-card>
      </div>
    </div>
</template>

<script lang="ts">
import { defineComponent, ref } from "vue"
const data = [
{
  ActionActivityId : "25776d50-36e5-4056-bf30-ca07157bc56d",
  UserId : "25776d50-36e5-4056-bf30-ca07157bc56d",
  ActionActivityName : "test"
},{
  ActionActivityId : "25776d50-36e5-4056-bf30-ca07157bc56d",
  UserId : "25776d50-36e5-4056-bf30-ca07157bc56d",
  ActionActivityName : "t1"
},{
  ActionActivityId : "25776d50-36e5-4056-bf30-ca07157bc56d",
  UserId : "25776d50-36e5-4056-bf30-ca07157bc56d",
  ActionActivityName : "t2"
},{
  ActionActivityId : "25776d50-36e5-4056-bf30-ca07157bc56d",
  UserId : "25776d50-36e5-4056-bf30-ca07157bc56d",
  ActionActivityName : "t1"
}]
export default defineComponent({
  data() {
    return {
      data
    }
  }
})
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

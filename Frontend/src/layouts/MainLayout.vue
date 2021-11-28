<template>
  <q-layout view="hHh Lpr fFf">
    <q-page-container>
      <router-view />
    </q-page-container>
    <div class="height-menu">
      <q-footer class="bottom-menu bg-primary ">
          <q-tabs v-model="tab" stretch indicator-color="transparent" >
            <q-route-tab to="mydevice" class="button-left-right"  name="mydevice"  >
              <q-avatar size="70px" icon="lightbulb" class="scalable-picture-size"/>
            </q-route-tab>
            <q-route-tab to="/"  class="button-left-right"  name="main" >
              <q-avatar size="70px" icon="dashboard" square class="scalable-picture-size"/>
            </q-route-tab>
            <q-route-tab to="profile" class="button-left-right"   name="profile" >
              <q-avatar size="70px" icon="perm_identity" class="scalable-picture-size" square  />
            </q-route-tab>
          </q-tabs>
      </q-footer>
    </div>
  </q-layout>
</template>

<script lang="ts">
import { defineComponent, ref } from "vue"

export default defineComponent({
  setup() {
    const tab = ref("main")
    return { tab }
  }
})
</script>

<style land="scss" scoped>
.button-left-right{
  width: 100%;
}
.height-menu{
  height:30px;
}
.bottom-menu {
  width: 100%;
  height: 50px;
}
.scalable-picture-size {
  width: 100%;
  height: 100%;
}
</style>
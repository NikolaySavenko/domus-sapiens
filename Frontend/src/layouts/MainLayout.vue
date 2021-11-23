<template>
  <q-layout view="hHh Lpr fFf">
    <q-page-container>
      <router-view />
    </q-page-container>
    <div class="height-menu">
      <q-footer class="bottom-menu bg-primary ">
          <q-tabs v-model="tab" align="center" indicator-color="transparent" dense>
            <q-route-tab to="mydevice" class="button-left-right"  name="mydevice" :ripple="false" >
              <q-btn round dense class="small-size-buttons" flat>
                <q-avatar icon="lightbulb" class="scalable-picture-size"/>
              </q-btn>
            </q-route-tab>
            <q-route-tab to="/" :ripple="false"  name="main" >
              <q-btn dense round class="small-size-buttons" flat>
                <q-avatar icon="dashboard" square class="scalable-picture-size"/>
              </q-btn>
            </q-route-tab>
            <q-route-tab to="profile" class="button-left-right" :ripple="false"  name="profile" >
              <q-btn round dense class="small-size-buttons" flat>
                <q-avatar icon="perm_identity" square class="scalable-picture-size" />
              </q-btn>
            </q-route-tab>
            <!--
              пока оставлю на всякий пожарный
              <q-route-tab to="mydevice" :ripple="false" name="rooms">
              <q-btn round dense class="small-size-buttons" flat>
                <q-avatar square class="scalable-picture-size">
                  <img src="../assets/dom.png">
                </q-avatar>
              </q-btn>
              </q-route-tab>
            <q-route-tab to="settings" :ripple="false" name="settings">
              <q-btn round dense class="small-size-buttons" flat>
                <q-avatar class="scalable-picture-size">
                  <img src="~assets\settings.png">
                </q-avatar>
              </q-btn>
            </q-route-tab>-->
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
  margin-right: auto;
  margin-left: auto;
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
.small-size-buttons {
  width: 10px;
  height: 10px;
}
</style>
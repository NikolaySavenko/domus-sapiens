<template>
  <q-layout view="hHh Lpr fFf">
    <q-page-container>
      <router-view />
    </q-page-container>
    <q-footer class="bottom-menu">
        <q-tabs v-model="tab" align="center" indicator-color="transparent" dense>
          <q-route-tab to="profile" name="profile" :ripple="false" >
            <q-btn round dense class="small-size-buttons" flat>
              <q-avatar class="scalable-picture-size">
                <img src="../assets/profile.png" >
              </q-avatar>
            </q-btn>
          </q-route-tab>
          <q-route-tab to="myrooms" :ripple="false" name="rooms" >
            <q-btn dense round class="small-size-buttons" flat>
              <q-avatar square class="scalable-picture-size">
                <img src="../assets/door.png">
              </q-avatar>
            </q-btn>
          </q-route-tab>
          <q-route-tab to="/" :ripple="false" name="main" >
            <q-btn round dense class="small-size-buttons" flat>
              <q-avatar square class="scalable-picture-size" >
                <img src="../assets/house.png">
              </q-avatar>
            </q-btn>
          </q-route-tab>
          <q-route-tab to="mydevice" :ripple="false" name="mydevice">
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
          </q-route-tab>
        </q-tabs>
    </q-footer>
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
.bottom-menu {
  border-radius: 30px 30px 0px 0px;
  position: absolute;
  width: 100%;
  height: 50px;
  background: linear-gradient(180deg, #C6AAFD 0%, #89EAF3 134%), linear-gradient(180deg, #65B5E1 0%, #2F496E 151.5%);;
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
<template>
  <q-layout view="hHh Lpr fFf">
    <q-page-container>
      <router-view />
    </q-page-container>
    <q-footer class="menuinbottom">
        <q-tabs v-model="tab" align="center" indicator-color="transparent" dense>
          <q-route-tab to="profile" name="profile" :ripple="false" >
            <q-btn round dense class="decrease1" flat>
              <q-avatar class="decrease">
                <img src="../assets/profile.png" >
              </q-avatar>
            </q-btn>
          </q-route-tab>
          <q-route-tab to="myrooms" :ripple="false" name="rooms" >
            <q-btn dense round class="decrease1" flat>
              <q-avatar square class="decrease">
                <img src="../assets/door.png">
              </q-avatar>
            </q-btn>
          </q-route-tab>
          <q-route-tab to="../" :ripple="false" name="main" >
            <q-btn round dense class="decrease1" flat>
              <q-avatar square class="decrease" >
                <img src="../assets/house.png">
              </q-avatar>
            </q-btn>
          </q-route-tab>
          <q-route-tab to="mydevice" :ripple="false" name="mydevice">
            <q-btn round dense class="decrease1" flat>
              <q-avatar square class="decrease">
                <img src="../assets/dom.png">
              </q-avatar>
            </q-btn>
            </q-route-tab>
          <q-route-tab to="settings" :ripple="false" name="settings">
            <q-btn round dense class="decrease1" flat>
              <q-avatar class="decrease">
                <img src="../assets/settings.png">
              </q-avatar>
            </q-btn>
          </q-route-tab>
        </q-tabs>
    </q-footer>
  </q-layout>
</template>
<script lang="ts">
</script>
<style land="scss" scoped>
.menuinbottom
{
  border-radius: 30px 30px 0px 0px;
  position: absolute;
  width: 100%;
  height: 50px;
}
.menuintop
{
  width: 100%;
  height: 50px;

  background: #83C57E;
  border: 1px solid #84C67E;
  box-sizing: border-box;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  border-radius: 0px 0px 50px 50px;
}
.decrease
{
  width: 100%;
  height: 100%;
}
.decrease1
{
  width: 10px;
  height: 10px;
}
</style>
<template>
    <div class="obj">
      <div class="row">
        <q-card class="col alignment">
          <q-card-actions align="center" class="el text-center bg-secondary">
            1
          </q-card-actions>
        </q-card>
        <q-card class="col alignment">
          <q-card-actions align="center" class="col el text-center bg-primary">
            2
          </q-card-actions>
        </q-card>
      </div>
      <div class="row">
        <q-card class="col alignment">
          <q-card-actions align="center" class="el text-center bg-primary">
            1
          </q-card-actions>
        </q-card>
        <q-card class="col alignment">
          <q-card-actions align="center" class="col el text-center bg-secondary">
            2
          </q-card-actions>
        </q-card>
      </div>
    </div>
</template>

<script lang="ts">
</script>

<style land="scss" scoped>
.obj {
  margin-left: auto;
  margin-right: auto;
  width: 362px;
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

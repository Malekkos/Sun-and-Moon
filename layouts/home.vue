<template>
  <div class="homeLayoutWrapper">
    <div class="navTop">
      <img src="../public/SUN.png"/>
      <img src="../public/&.png"/>
      <img src="../public/MOON.png"/>
    </div>
    <slot>
    </slot>
    <div class="navBottom">
    home layout ~ Home page bottom
    </div>
  </div>
</template>

<script lang="ts" setup>


</script>

<style lang="postcss" scoped>

  .navTop, .navBottom {
    @apply flex justify-center w-full h-20 items-center;
  }

  .homeLayoutWrapper {
    @apply w-full bg-[#FFE7B8];
  }
</style>
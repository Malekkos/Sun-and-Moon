<template>
  <div class="homeLayoutWrapper">
    <div class="navTop">
      home layout ~ Home page top
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
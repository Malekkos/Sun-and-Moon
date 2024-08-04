<!-- 
This will be the page displayed if you attempt to navigate to a page that isn't recognized in the heirarchy. 

Interestingly, with tests, this only seems to work when entering places that have a different url structure.
cont. Meaning, entering .../fdasgafsdg/sdfgsdfg would actually return something(it shouldnt). However, it would
cont. work when we enter something like .../asdgfg/sdfgsdfg/sdfgsdfg. This is due to it checking for a path name, 
cont. not strictly if such a thing exists. 

Solution here would likely be initiating a redirect to this page when making calls to retrieve information.
-->


<template>
  <div>
    {{ $route.params.notfound }}
  </div>
</template>

<script lang="ts" setup>
  definePageMeta({
    title: "Page not found..."
  })
</script>

<style>

</style>
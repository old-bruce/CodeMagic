<template>
    <!-- {_Name_} -->
    <div>
        <!-- TODO -->
    </div>
</template>

<script>
    export default {
        name: '{_Name_}',
        props: [
            {_Props_}
        ],
        data() {
          return {
            
          }
        },
        methods: {
          loadData() {
            console.log('[{_Name_}] loadData');
            var requestData = {
                //TODO:
            };
            console.log('POST => ' + JSON.stringify(requestData));

            this.$axios.post('/', requestData).then((response)=>{
              for (var i = 0; i < response.data.Data; i++) {
                  //TODO:
              }
            });
          },
        },
        mounted(){
          console.log('[{_Name_}] mounted');
          this.loadData();
        }
    }
</script>

<style type="text/css" scoped>

</style>